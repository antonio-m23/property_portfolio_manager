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
│
└── property_portfolio_manager/
    ├── Data/                # SQLite access and database initialization
    │   └── Repositories/    # SQL queries and data persistence
    ├── Models/              # Application entities and data structures
    ├── Presentation/        # Windows Forms user interface
    │   ├── Controls/        # Reusable UI components
    │   ├── Forms/           # Application windows and dialogs
    │   └── Views/           # Individual application screens
    ├── Services/            # Business rules and financial calculations
    ├── Form1.cs             # Initial Windows Form (to be renamed)
    └── Program.cs           # Application entry point

```

The structure will be populated progressively as the application is developed.

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

Open the project in Visual Studio 2026.

Build the application using Visual Studio or the .NET CLI:

```bash
dotnet build
```

**Note:** The application is currently under development. The initial project contains the Windows Forms application scaffold; the portfolio management features are not yet available.

---

## 🧪 Testing

Automated tests and functional verification will be introduced as the application is implemented.

The testing process will focus on:

- Property and contract data validation
- Prevention of overlapping rental contracts
- Monthly payment generation and duplicate prevention
- Maintenance and expense consistency
- Financial calculations and investment performance
- SQLite database integrity

Testing instructions and results will be documented as the corresponding features are completed.

---

## 🛠️ Technologies

- **C#** — Core programming language
- **.NET 10** — Application framework
- **Windows Forms** — Desktop graphical user interface
- **SQLite** — Planned local relational database
- **Microsoft.Data.Sqlite** — Planned database access library
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