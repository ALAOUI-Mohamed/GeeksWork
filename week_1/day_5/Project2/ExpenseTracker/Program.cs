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
    static void AddTransaction() { }
    static void ViewTransactions() { }
    static void UpdateTransaction() { }
    static void DeleteTransaction() { }
    static void ViewSummary() { }
}
