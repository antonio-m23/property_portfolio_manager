using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Data.Sqlite;

namespace property_portfolio_manager.Data
{
    internal static class DatabaseInitializer
    {
        private const int CurrentSchemaVersion = 1;

        public static void Initialize()
        {
            Directory.CreateDirectory(DatabasePaths.DirectoryPath);

            using var connection = DatabaseConnectionFactory.Create();
            connection.Open();

            // Read the current database schema version
            using var versionCommand = connection.CreateCommand();
            versionCommand.CommandText = "PRAGMA user_version;";

            int version = Convert.ToInt32(versionCommand.ExecuteScalar());

            // The database is already initializzed 
            if (version == CurrentSchemaVersion)
            {
                return;
            }

            // Other versions require an explicit migration
            if (version != 0)
            {
                throw new NotSupportedException(
                    $"Unsupported database schema version: {version}");
            }

            // Create the initial schema in a single transaction
            using var transaction = connection.BeginTransaction();

            using var command = connection.CreateCommand();
            command.Transaction = transaction;

            string[] scripts =
            {
                DatabaseSchema.CreatePropertiesTable,
                DatabaseSchema.CreateRentalContractsTable,
                DatabaseSchema.CreateRentPaymentsTable,
                DatabaseSchema.CreateMaintenanceRequestsTable,
                DatabaseSchema.CreateExpensesTable,
                DatabaseSchema.CreateDeadlinesTable,
                DatabaseSchema.CreatePropertySalesTable,
                DatabaseSchema.CreateOpeningBalancesTable,
                DatabaseSchema.CreateIndexes,
                DatabaseSchema.CreateContractOverlapTriggers,
                DatabaseSchema.CreateSaleIntegrityTriggers
            };


            foreach (string sql in scripts)
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }

            // Mark the database as schema version 1
            command.CommandText = "PRAGMA user_version = 1;";
            command.ExecuteNonQuery();

            transaction.Commit();
        }
    }
}