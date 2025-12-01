using System;

class Program
{
    static TransactionManager manager = new TransactionManager();

    static void Main()
    {
        // Load transactions from file at start
        manager.Load(DataStore.Load());
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== PERSONAL EXPENSE TRACKER =====");
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. View Transactions");
            Console.WriteLine("3. Update Transaction");
            Console.WriteLine("4. Delete Transaction");
            Console.WriteLine("5. View Summary / Analysis");
            Console.WriteLine("6. Exit");
            Console.WriteLine("7. Filter by Category");
            Console.Write("Select option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddTransaction();
                    break;

                case "2":
                    ViewTransactions();
                    break;

                case "3":
                    UpdateTransaction();
                    break;

                case "4":
                    DeleteTransaction();
                    break;

                case "5":
                    ViewSummary();
                    break;

                case "6":
                    // Save transactions to file
                    DataStore.Save(manager.GetAll());
                    Console.WriteLine("Transactions saved. Goodbye!");
                    return;
                case "7":
                    FilterByCategory();
                    break;

                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    // Placeholder methods — we will fill these in Step 5
    static void AddTransaction()
    {
        Console.Clear();
        Console.WriteLine("=== Add Transaction ===");

        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Amount (positive for income, negative for expense): ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.Write("Category: ");
        string category = Console.ReadLine();

        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        manager.AddTransaction(title, amount, category, date);

        Console.WriteLine("\nTransaction added successfully!");
        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }

    static void ViewTransactions()
    {
        Console.Clear();
        Console.WriteLine("=== All Transactions ===\n");

        var list = manager.GetAll();

        if (list.Count == 0)
        {
            Console.WriteLine("No transactions found.");
            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("ID | Title           | Amount      | Category       | Date");
        Console.WriteLine("---------------------------------------------------------------");

        foreach (var t in list)
        {
            if (t.Amount >= 0)
                Console.ForegroundColor = ConsoleColor.Green;   // income = green
            else
                Console.ForegroundColor = ConsoleColor.Red;     // expense = red

            Console.WriteLine(
                $"{t.Id,-3}| {t.Title,-15}| {t.Amount,-12}| {t.Category,-15}| {t.Date.ToShortDateString()}"
            );

            Console.ResetColor();
        }

        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }

    static void UpdateTransaction()
    {
        Console.Clear();
        Console.WriteLine("=== Update Transaction ===");

        Console.Write("Enter the transaction ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            Console.ReadLine();
            return;
        }

        var tr = manager.GetById(id);
        if (tr == null)
        {
            Console.WriteLine("Transaction not found.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("\nLeave a field empty to keep the current value.\n");

        Console.WriteLine($"Current Title: {tr.Title}");
        Console.Write("New Title: ");
        string newTitle = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newTitle))
            tr.Title = newTitle;

        Console.WriteLine($"Current Amount: {tr.Amount}");
        Console.Write("New Amount: ");
        string newAmountInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newAmountInput) &&
            decimal.TryParse(newAmountInput, out decimal newAmount))
            tr.Amount = newAmount;

        Console.WriteLine($"Current Category: {tr.Category}");
        Console.Write("New Category: ");
        string newCategory = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newCategory))
            tr.Category = newCategory;

        Console.WriteLine($"Current Date: {tr.Date.ToShortDateString()}");
        Console.Write("New Date (yyyy-mm-dd): ");
        string newDateInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newDateInput) &&
            DateTime.TryParse(newDateInput, out DateTime newDate))
            tr.Date = newDate;

        Console.WriteLine("\nTransaction updated successfully!");
        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }
    static void DeleteTransaction()
    {
        Console.Clear();
        Console.WriteLine("=== Delete Transaction ===");

        Console.Write("Enter the transaction ID to delete: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            Console.ReadLine();
            return;
        }

        var tr = manager.GetById(id);
        if (tr == null)
        {
            Console.WriteLine("Transaction not found.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine($"\nAre you sure you want to delete '{tr.Title}' (Y/N)?");
        string confirm = Console.ReadLine().Trim().ToUpper();

        if (confirm == "Y")
        {
            manager.DeleteTransaction(id);
            Console.WriteLine("Transaction deleted successfully!");
        }
        else
        {
            Console.WriteLine("Delete canceled.");
        }

        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }
    static void ViewSummary()
    {
        Console.Clear();
        Console.WriteLine("=== Summary / Analysis ===\n");

        decimal totalIncome = manager.TotalIncome();
        decimal totalExpenses = manager.TotalExpenses();
        decimal balance = manager.Balance();

        Console.WriteLine($"Total Income:  {totalIncome:C}");
        Console.WriteLine($"Total Expenses:{totalExpenses:C}");
        Console.WriteLine($"Balance:       {balance:C}\n");

        Console.WriteLine("Expenses by Category:");
        var grouped = manager.ExpensesByCategory();

        if (!grouped.Any())
        {
            Console.WriteLine("No expense transactions found.");
        }
        else
        {
            foreach (var grp in grouped)
            {
                decimal sum = grp.Sum(t => Math.Abs(t.Amount));
                Console.WriteLine($"{grp.Key}: {sum:C}");
            }
        }

        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }

    static void FilterByCategory()
    {
        Console.Clear();
        Console.WriteLine("=== Filter By Category ===");
        Console.Write("Enter category name: ");

        string category = Console.ReadLine();

        var filtered = manager.GetAll()
                              .Where(t => t.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                              .ToList();

        if (filtered.Count == 0)
        {
            Console.WriteLine("\nNo transactions found for this category.");
            Console.WriteLine("Press Enter to return...");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("\nID | Title           | Amount      | Category       | Date");
        Console.WriteLine("---------------------------------------------------------------");

        foreach (var t in filtered)
        {
            if (t.Amount >= 0)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{t.Id,-3}| {t.Title,-15}| {t.Amount,-12}| {t.Category,-15}| {t.Date.ToShortDateString()}");

            Console.ResetColor();
        }

        Console.WriteLine("\nPress Enter to return...");
        Console.ReadLine();
    }

}
