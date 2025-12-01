using System;

class Program
{
    static TransactionManager manager = new TransactionManager();

    static void Main()
    {
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
                    return;

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
            Console.WriteLine($"{t.Id,-3}| {t.Title,-15}| {t.Amount,-12}| {t.Category,-15}| {t.Date.ToShortDateString()}");
        }

        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }

    static void UpdateTransaction() { }
    static void DeleteTransaction() { }
    static void ViewSummary() { }
}
