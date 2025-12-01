# 📊 Personal Expense Tracker (C# Console App)

A console-based Personal Expense Tracker built in **C#**.  
This application allows users to manage income and expenses, view summaries, filter and sort transactions, and persist data using JSON.  
It also includes advanced features like exporting reports and color-coded output.

---

## 🚀 Features

### ✔ Core Features
- Add new income/expense transactions  
- View all transactions in a clean table format  
- Update existing transactions  
- Delete transactions  
- Summary view including:
  - Total income  
  - Total expenses  
  - Balance  
  - Expenses grouped by category  

### ✔ Data Persistence
- Automatically **loads data** from `transactions.json` on startup  
- Automatically **saves data** to `transactions.json` on exit  

### ✔ Advanced Features
- Color-coded output (Green = income, Red = expense)  
- Filter transactions by category  
- Filter transactions by date range  
- Sort transactions:
  - Date (newest → oldest / oldest → newest)  
  - Amount (highest → lowest / lowest → highest)  
- Export summary report to a text file (`summary_report.txt`)  
- Show recent transactions from the **last 7 days**  

---

## 🏗 Technologies Used
- **C# .NET Console Application**
- **System.Text.Json** for JSON save/load
- **LINQ** for filtering, sorting, grouping
- **File I/O** for persistence and report exporting
- **Git & GitHub** for version control

---

## 📁 Project Structure

ExpenseTracker/
│
├── Program.cs
├── Transaction.cs
├── TransactionManager.cs
├── DataStore.cs
├── transactions.json # Auto-generated
└── summary_report.txt # Generated when exporting summary

yaml
Copy code

---

## 🖥 How to Run

### 1️⃣ Clone the repository
```bash
git clone https://github.com/<your-username>/<your-repo>.git
cd ExpenseTracker
2️⃣ Run the project
bash
Copy code
dotnet run
3️⃣ Use the interactive menu in the console.
📄 Example Menu
pgsql
Copy code
1. Add Transaction
2. View Transactions
3. Update Transaction
4. Delete Transaction
5. View Summary / Analysis
6. Exit
7. Filter by Category
8. Filter by Date Range
9. Sort Transactions
10. Export Summary Report
11. Show Recent Transactions (Last 7 Days)
📊 Summary Report Example
A generated summary_report.txt looks like:

yaml
Copy code
=== Summary Report ===

Total Income:   $2500.00
Total Expenses: $1200.00
Balance:        $1300.00

Expenses by Category:
Food: $300.00
Rent: $700.00
Transport: $200.00

Report generated on: 2025-12-01 15:30
📚 Git Workflow Used
This project follows clean version control practices:

✔ Initial Git Setup
Created a new project folder

Initialized Git repository

Added initial README and first commit

✔ Incremental Commits
Meaningful commits were made after each feature:

Transaction Class

Add/View/Update/Delete

Summary and analysis

Save/Load JSON feature

All advanced features

✔ Branching
Created a branch: feature/save-load

Implemented Save/Load

Merged back into main

✔ Hosted on GitHub
Repository pushed with a clean commit history.

⭐ Future Improvements (Optional)
CSV exporting

Monthly spending charts

Converting to WinForms/WPF UI

Adding SQLite database support

Adding recurring expenses

👤 Author
Your Name
GitHub: https://github.com/ALAOUI-Mohamed
Email: xxx