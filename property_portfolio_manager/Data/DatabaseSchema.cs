using System;
using System.Collections.Generic;
using System.Text;


namespace property_portfolio_manager.Data
{
    internal static class DatabaseSchema
    {
        public const string CreatePropertiesTable = """
            CREATE TABLE IF NOT EXISTS Properties (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,

                PropertyType INTEGER NOT NULL
                    CHECK (PropertyType IN (1, 2, 3)),

                Address TEXT NOT NULL
                    CHECK (length(trim(Address)) > 0),

                City TEXT NOT NULL
                    CHECK (length(trim(City)) > 0),

                AreaSqm REAL
                    CHECK (AreaSqm IS NULL OR AreaSqm > 0),

                PurchaseDate TEXT NOT NULL,

                PurchasePriceCents INTEGER NOT NULL
                    CHECK (PurchasePriceCents >= 0),

                AcquisitionCostsCents INTEGER NOT NULL DEFAULT 0
                    CHECK (AcquisitionCostsCents >= 0),

                ExpectedMonthlyRentCents INTEGER NOT NULL DEFAULT 0
                    CHECK (ExpectedMonthlyRentCents >= 0)
            );
            """;

        public const string CreateRentalContractsTable = """
            CREATE TABLE IF NOT EXISTS RentalContracts (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,

                PropertyId INTEGER NOT NULL,

                TenantName TEXT NOT NULL
                    CHECK (length(trim(TenantName)) > 0),

                StartDate TEXT NOT NULL,

                PlannedEndDate TEXT NOT NULL,

                ActualEndDate TEXT,

                MonthlyRentCents INTEGER NOT NULL
                    CHECK (MonthlyRentCents > 0),

                DueDay INTEGER NOT NULL
                    CHECK (DueDay BETWEEN 1 AND 31),

                CHECK (PlannedEndDate >= StartDate),

                CHECK (
                    ActualEndDate IS NULL
                    OR (
                        ActualEndDate >= StartDate
                        AND ActualEndDate <= PlannedEndDate
                    )
                ),

                FOREIGN KEY (PropertyId)
                    REFERENCES Properties(Id)
                    ON DELETE RESTRICT
            );
            """;


        public const string CreateRentPaymentsTable = """
            CREATE TABLE IF NOT EXISTS RentPayments (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,

            ContractId INTEGER NOT NULL,

            ReferenceYear INTEGER NOT NULL
                CHECK (ReferenceYear BETWEEN 1 AND 9999),

            ReferenceMonth INTEGER NOT NULL
                CHECK (ReferenceMonth BETWEEN 1 AND 12),

            AmountDueCents INTEGER NOT NULL
                CHECK (AmountDueCents > 0),

            DueDate TEXT NOT NULL,

            PaidDate TEXT,

            UNIQUE (ContractId, ReferenceYear, ReferenceMonth),

            FOREIGN KEY (ContractId)
                REFERENCES RentalContracts(Id)
                ON DELETE RESTRICT
        );
        """;


        public const string CreateMaintenanceRequestsTable = """
            CREATE TABLE IF NOT EXISTS MaintenanceRequests (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,

                PropertyId INTEGER NOT NULL,

                Title TEXT NOT NULL
                    CHECK (length(trim(Title)) > 0),

                Description TEXT,

                Priority INTEGER NOT NULL
                    CHECK (Priority IN (1, 2, 3)),

                Status INTEGER NOT NULL DEFAULT 1
                    CHECK (Status IN (1, 2, 3, 4)),

                ReportedDate TEXT NOT NULL,

                ScheduledDate TEXT,

                CompletedDate TEXT,

                EstimatedCostCents INTEGER
                    CHECK (
                        EstimatedCostCents IS NULL
                        OR EstimatedCostCents >= 0
                    ),

                CHECK (
                    CompletedDate IS NULL
                    OR CompletedDate >= ReportedDate
                ),

                CHECK (
                    (Status = 4 AND CompletedDate IS NOT NULL)
                    OR
                    (Status <> 4 AND CompletedDate IS NULL)
                ),

                UNIQUE (Id, PropertyId),

                FOREIGN KEY (PropertyId)
                    REFERENCES Properties(Id)
                    ON DELETE RESTRICT
            );
            """;


        public const string CreateExpensesTable = """
            CREATE TABLE IF NOT EXISTS Expenses (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,

                PropertyId INTEGER NOT NULL,

                MaintenanceRequestId INTEGER UNIQUE,

                Category INTEGER NOT NULL
                    CHECK (Category IN (1, 2, 3, 4)),

                Description TEXT NOT NULL
                    CHECK (length(trim(Description)) > 0),

                ExpenseDate TEXT NOT NULL,

                AmountCents INTEGER NOT NULL
                    CHECK (AmountCents > 0),

                CHECK (
                    (Category = 1 AND MaintenanceRequestId IS NOT NULL)
                    OR
                    (Category IN (2, 3, 4) AND MaintenanceRequestId IS NULL)
                ),

                FOREIGN KEY (PropertyId)
                    REFERENCES Properties(Id)
                    ON DELETE RESTRICT,

                FOREIGN KEY (MaintenanceRequestId, PropertyId)
                    REFERENCES MaintenanceRequests(Id, PropertyId)
                    ON DELETE RESTRICT
            );
            """;


        public const string CreateDeadlinesTable = """
            CREATE TABLE IF NOT EXISTS Deadlines (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,

                PropertyId INTEGER,

                Title TEXT NOT NULL
                    CHECK (length(trim(Title)) > 0),

                Description TEXT,

                DueDate TEXT NOT NULL,

                CompletedDate TEXT,

                FOREIGN KEY (PropertyId)
                    REFERENCES Properties(Id)
                    ON DELETE RESTRICT
            );
            """;


        public const string CreatePropertySalesTable = """
            CREATE TABLE IF NOT EXISTS PropertySales (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,

                PropertyId INTEGER NOT NULL UNIQUE,

                SaleDate TEXT NOT NULL,

                SalePriceCents INTEGER NOT NULL
                    CHECK (SalePriceCents > 0),

                SellingCostsCents INTEGER NOT NULL DEFAULT 0
                    CHECK (SellingCostsCents >= 0),

                Notes TEXT,

                FOREIGN KEY (PropertyId)
                    REFERENCES Properties(Id)
                    ON DELETE RESTRICT
            );
            """;


        public const string CreateOpeningBalancesTable = """
            CREATE TABLE IF NOT EXISTS OpeningBalances (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,

                PropertyId INTEGER NOT NULL UNIQUE,

                TrackingStartDate TEXT NOT NULL
                    CHECK (
                        length(TrackingStartDate) = 10
                        AND substr(TrackingStartDate, 9, 2) = '01'
                    ),

                PreviousRentCollectedCents INTEGER NOT NULL DEFAULT 0
                    CHECK (PreviousRentCollectedCents >= 0),

                PreviousOperatingExpensesCents INTEGER NOT NULL DEFAULT 0
                    CHECK (PreviousOperatingExpensesCents >= 0),

                FOREIGN KEY (PropertyId)
                    REFERENCES Properties(Id)
                    ON DELETE RESTRICT
            );
            """;


        public const string CreateIndexes = """
            CREATE INDEX IF NOT EXISTS IX_RentalContracts_PropertyId_StartDate
                ON RentalContracts (PropertyId, StartDate);

            CREATE INDEX IF NOT EXISTS IX_RentPayments_Unpaid_DueDate
                ON RentPayments (DueDate)
                WHERE PaidDate IS NULL;

            CREATE INDEX IF NOT EXISTS IX_MaintenanceRequests_PropertyId_Status
                ON MaintenanceRequests (PropertyId, Status);

            CREATE INDEX IF NOT EXISTS IX_Expenses_PropertyId_ExpenseDate
                ON Expenses (PropertyId, ExpenseDate);

            CREATE INDEX IF NOT EXISTS IX_Deadlines_Open_DueDate
                ON Deadlines (DueDate)
                WHERE CompletedDate IS NULL;
            """;


        public const string CreateContractOverlapTriggers = """
            CREATE TRIGGER IF NOT EXISTS
                TR_RentalContracts_NoOverlap_Insert
            BEFORE INSERT ON RentalContracts
            FOR EACH ROW
            WHEN EXISTS (
                SELECT 1
                FROM RentalContracts AS existing
                WHERE existing.PropertyId = NEW.PropertyId
                  AND existing.StartDate <=
                      COALESCE(NEW.ActualEndDate, NEW.PlannedEndDate)
                  AND COALESCE(
                      existing.ActualEndDate,
                      existing.PlannedEndDate
                  ) >= NEW.StartDate
            )
            BEGIN
                SELECT RAISE(
                    ABORT,
                    'Rental contracts cannot overlap'
                );
            END;

            CREATE TRIGGER IF NOT EXISTS
                TR_RentalContracts_NoOverlap_Update
            BEFORE UPDATE OF
                PropertyId, StartDate, PlannedEndDate, ActualEndDate
            ON RentalContracts
            FOR EACH ROW
            WHEN EXISTS (
                SELECT 1
                FROM RentalContracts AS existing
                WHERE existing.PropertyId = NEW.PropertyId
                  AND existing.Id <> OLD.Id
                  AND existing.StartDate <=
                      COALESCE(NEW.ActualEndDate, NEW.PlannedEndDate)
                  AND COALESCE(
                      existing.ActualEndDate,
                      existing.PlannedEndDate
                  ) >= NEW.StartDate
            )
            BEGIN
                SELECT RAISE(
                    ABORT,
                    'Rental contracts cannot overlap'
                );
            END;
            """;


        public const string CreateSaleIntegrityTriggers = """
            CREATE TRIGGER IF NOT EXISTS
                TR_PropertySales_Validate_Insert
            BEFORE INSERT ON PropertySales
            FOR EACH ROW
            WHEN EXISTS (
                SELECT 1
                FROM RentalContracts AS contract
                WHERE contract.PropertyId = NEW.PropertyId
                  AND COALESCE(
                      contract.ActualEndDate,
                      contract.PlannedEndDate
                  ) >= NEW.SaleDate
            )
            BEGIN
                SELECT RAISE(
                    ABORT,
                    'Cannot sell a property with active or future contracts'
                );
            END;

            CREATE TRIGGER IF NOT EXISTS
                TR_PropertySales_Validate_Update
            BEFORE UPDATE OF PropertyId, SaleDate
            ON PropertySales
            FOR EACH ROW
            WHEN EXISTS (
                SELECT 1
                FROM RentalContracts AS contract
                WHERE contract.PropertyId = NEW.PropertyId
                  AND COALESCE(
                      contract.ActualEndDate,
                      contract.PlannedEndDate
                  ) >= NEW.SaleDate
            )
            BEGIN
                SELECT RAISE(
                    ABORT,
                    'Cannot sell a property with active or future contracts'
                );
            END;

            CREATE TRIGGER IF NOT EXISTS
                TR_RentalContracts_ValidateSale_Insert
            BEFORE INSERT ON RentalContracts
            FOR EACH ROW
            WHEN EXISTS (
                SELECT 1
                FROM PropertySales AS sale
                WHERE sale.PropertyId = NEW.PropertyId
                  AND COALESCE(
                      NEW.ActualEndDate,
                      NEW.PlannedEndDate
                  ) >= sale.SaleDate
            )
            BEGIN
                SELECT RAISE(
                    ABORT,
                    'Rental contract conflicts with property sale'
                );
            END;

            CREATE TRIGGER IF NOT EXISTS
                TR_RentalContracts_ValidateSale_Update
            BEFORE UPDATE OF
                PropertyId, StartDate, PlannedEndDate, ActualEndDate
            ON RentalContracts
            FOR EACH ROW
            WHEN EXISTS (
                SELECT 1
                FROM PropertySales AS sale
                WHERE sale.PropertyId = NEW.PropertyId
                  AND COALESCE(
                      NEW.ActualEndDate,
                      NEW.PlannedEndDate
                  ) >= sale.SaleDate
            )
            BEGIN
                SELECT RAISE(
                    ABORT,
                    'Rental contract conflicts with property sale'
                );
            END;
            """;

    }
}
