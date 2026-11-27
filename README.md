# 🏠 Real Estate Portfolio Dashboard

A Windows desktop application developed in **C# with .NET 10 and Windows Forms**, designed to manage real estate properties, rental contracts, payments, operating expenses, maintenance, and investment performance.

The project aims to provide property owners with a centralized tool for monitoring their real estate portfolio, tracking rental income, managing financial records, and evaluating investment results.

The application is designed around a **modular architecture**, separating the user interface, data models, business logic, and database operations to keep the code organized and maintainable.

**Project Status:** In Development

---

## ✨ Features

The following features are planned for the first release:

- [ ] **Property Management** — Add, edit, and view properties, including acquisition details and occupancy information.
- [ ] **Tenant & Contract Management** — Manage tenant records, rental contracts, and contract history.
- [ ] **Rent Payment Tracking** — Automatically generate monthly rent obligations and track paid, pending, and overdue payments.
- [ ] **Maintenance Management** — Organize maintenance requests by priority, status, and scheduled dates.
- [ ] **Expense Tracking** — Record operating expenses and maintenance costs without duplicate entries.
- [ ] **Deadlines & Reminders** — Monitor contract expirations, payment deadlines, maintenance schedules, and custom reminders.
- [ ] **Financial Performance** — Analyze rental income, operating expenses, investment recovery, and property profitability.
- [ ] **Property Sales** — Record property sales while preserving historical financial information.
- [ ] **Portfolio Dashboard** — Display essential portfolio statistics and items requiring attention.


---

## 🏗️ Current Implementation

The application foundation is implemented and includes:

- **Modern Windows Forms Interface** — A resizable desktop layout with a navy sidebar, page header, and dedicated content area.
- **Dynamic Navigation** — Six navigable screens (Dashboard, Properties, Payments, Maintenance, Deadlines, and Performance), with automatic page titles and active navigation highlighting.
- **Modular UI Architecture** — Separate `UserControl` views and reusable navigation logic.
- **SQLite Integration** — Automatic initialization of a local SQLite database using `Microsoft.Data.Sqlite`.
- **Database Schema** — Eight relational tables, five indexes, and six integrity triggers.
- **Data Integrity** — Foreign key constraints, validation rules, duplicate prevention, and database-level protection against overlapping rental contracts and conflicting property sales.
- **Schema Versioning** — Initial database schema version tracked through `PRAGMA user_version`.

The application currently provides a functional navigation shell and an initialized database. Property management workflows, CRUD operations, and financial calculations are still under development.


---

## 🧠 How It Works

The application is designed around a simple property management workflow:

1. Register a property and its acquisition details.
2. Add tenant information and create a rental contract.
3. Generate monthly rent obligations based on the contract.
4. Record received payments and identify outstanding rent.
5. Track maintenance activities and operating expenses.
6. Monitor deadlines and review portfolio performance.
7. Record property sales while preserving financial history.

Each property maintains its associated contracts, payments, expenses, and maintenance records.

The application will use a local **SQLite database** to store information and calculate financial indicators from recorded transactions.

Properties will be classified automatically as occupied, vacant, or sold based on their contracts and sale records.

The system is designed to preserve historical data and provide a clear overview of both active investments and completed property sales.

---

## 🧮 Financial Calculations

The application is designed to evaluate the financial performance of individual properties and the overall portfolio.

The **Total Initial Investment** includes both the purchase price and acquisition costs:

`Initial Investment = Purchase Price + Acquisition Costs`

The **Net Rental Income** is calculated from actual rental income and operating expenses:

`Net Rental Income = Rent Collected - Operating Expenses`

For sold properties, the investment result also considers the sale proceeds and selling costs:

`Net Result = Rent Collected - Operating Expenses + Sale Price - Selling Costs - Initial Investment`

Financial calculations will distinguish historical opening balances from detailed transactions recorded after the monitoring start date.

Rental income will be attributed to the actual payment date, allowing outstanding payments to be recorded even after a rental contract ends or a property is sold.

The first release focuses on **simplified, cash-based investment analysis** rather than complete tax or accounting management.

---

## 📁 Project Structure

The project follows a modular structure organized by responsibility:

```text


property_portfolio_manager/
│
├── .gitignore
├── LICENSE
├── README.md
├── property_portfolio_manager.slnx
│
└── property_portfolio_manager/
    │
    ├── property_portfolio_manager.csproj
    ├── Program.cs
    │
    ├── Data/
    │   ├── Repositories/
    │   ├── DatabasePaths.cs
    │   ├── DatabaseConnectionFactory.cs
    │   ├── DatabaseInitializer.cs
    │   └── DatabaseSchema.cs
    │
    ├── Models/
    │
    ├── Presentation/
    │   ├── Controls/
    │   ├── Forms/
    │   │   └── MainForm.cs
    │   └── Views/
    │       ├── DashboardView.cs
    │       ├── PropertiesView.cs
    │       ├── PaymentsView.cs
    │       ├── MaintenanceView.cs
    │       ├── DeadlinesView.cs
    │       └── PerformanceView.cs
    │
    └── Services/


```

The presentation layer and SQLite database foundation are implemented. The `Models`, `Services`, and `Repositories` directories will be populated as the corresponding application features are developed.

Windows Forms Designer and resource files are omitted from the diagram for readability. The SQLite database is stored separately in the user's local application data directory, outside the Git repository.

This separation aims to keep the codebase clean, maintainable, and easier to navigate and extend.

---

## 🚀 Getting Started

### Requirements

- Windows
- Visual Studio 2026 with .NET desktop development support
- .NET 10 SDK
- Git (optional, for cloning the repository)

Clone the repository:

```bash
git clone https://github.com/antonio-m23/property_portfolio_manager.git
cd property_portfolio_manager
```


Open `property_portfolio_manager.slnx` in Visual Studio 2026.

Build and run the application using Visual Studio, or press `Ctrl + F5` to start without debugging.

Alternatively, from the repository root, use the .NET CLI:

```bash
dotnet restore
dotnet build
dotnet run --project property_portfolio_manager/property_portfolio_manager.csproj
```

### Local Database

The application automatically creates and initializes a local SQLite database on its first launch.

The database is stored at:

```text
%LOCALAPPDATA%\PropertyPortfolioManager\portfolio.db
```

The initial schema includes eight relational tables, five indexes, and six integrity triggers.

The database is stored outside the project directory and is not included in the Git repository.

**Development Status:** The application currently provides a functional Windows Forms interface with navigation between six sections and an initialized SQLite database. Property management operations, financial calculations, and the remaining application features are still under development.

---


## 🧪 Testing

The project has undergone initial manual build, runtime, and database verification.

### Completed Checks

- **Build Verification** — Successfully compiled using `dotnet build` with .NET 10.
- **Application Startup** — Verified that the Windows Forms application launches successfully.
- **Navigation Testing** — Manually verified navigation between all six application sections, including page switching, header updates, and active button highlighting.
- **SQLite Initialization** — Verified automatic database creation and successful initialization across multiple application launches.
- **Database Schema Verification** — Confirmed schema version 1, eight relational tables, five application indexes, and six integrity triggers.
- **Referential Integrity** — Verified `PRAGMA foreign_key_check` and confirmed that SQLite rejects a rental contract referencing a nonexistent property.
- **Transaction Rollback** — Confirmed that the foreign key validation test did not persist test data.

### Planned Tests

Automated tests will be introduced as the application features are implemented, focusing on:

- Property and rental contract validation, including overlapping contract prevention.
- Monthly rent generation and duplicate payment prevention.
- Maintenance and expense consistency.
- Property sale restrictions and historical data preservation.
- Financial calculations, investment recovery, and portfolio performance.
- SQLite constraints, schema initialization, and future database migrations.

The existing checks validate the application foundation but do not yet represent a comprehensive automated test suite.

---

## 🛠️ Technologies

- **C#** — Core programming language
- **.NET 10** — Application framework
- **Windows Forms** — Desktop graphical user interface and navigation
- **SQLite** — Local relational database with schema versioning and integrity constraints
- **Microsoft.Data.Sqlite (10.0.15)** — ADO.NET provider for SQLite connections and database operations
- **Visual Studio 2026** — Development environment
- **Git & GitHub** — Version control and project hosting

---

## 🔮 Future Improvements

Possible future improvements include:

- Adding interactive financial charts and investment trends
- Introducing calendar views for deadlines and rental payments
- Implementing a Kanban board for maintenance management
- Supporting customizable expense categories
- Adding a dark theme and alternative property card views
- Introducing desktop notifications for important deadlines
- Supporting partial rental payments and more flexible payment schedules
- Expanding financial forecasting and investment analysis

These features are outside the initial release scope and may be considered after the core application is completed.

---

## 📄 License

This project is licensed under the MIT License.

See the [LICENSE](LICENSE) file for details.