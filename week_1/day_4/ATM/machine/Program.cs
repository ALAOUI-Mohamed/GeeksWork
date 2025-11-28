using System;
using System.Collections.Generic;

namespace ATMMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating sample accounts
            Account FaroukAccount = new Account("11282025", 1234, 100000.0);
            Account MohamedAccount = new Account("11282026", 5678, 50000.0);
            Account KarimAccount = new Account("11282027", 9101, 750000.0);
            
            // Initializing ATM
            ATM atm = new ATM();
            Console.WriteLine("Welcome to the ATM!");
            Console.WriteLine("--------------------------------");
            
            // Using a list to manage multiple accounts
            List<Account> accounts = new List<Account> { FaroukAccount, MohamedAccount, KarimAccount };
            
            bool keepRunning = true;
            while (keepRunning)
            {
                // Authentication with attempt limit
                Account currentAccount = atm.Authenticate(accounts);
                Console.WriteLine("--------------------------------");
                
                // If authentication is successful, show menu and perform actions
                if (currentAccount != null)
                {
                    Console.WriteLine("Authentication Successful!");
                    int choice = 0;
                    // Main loop to show menu and perform actions until user exits or switches account
                    while (choice != 7)
                    {
                        atm.ShowMenu();
                        Console.WriteLine("Select an option: ");
                        if (!int.TryParse(Console.ReadLine(), out choice))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }
                        
                        if (choice == 7)
                        {
                            break;
                        }
                        
                        atm.PerformAction(currentAccount, choice);
                        
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Press any key to access the menu...");
                        Console.WriteLine("--------------------------------");
                        Console.ReadKey();
                    }
                    
                    // Show options after exiting account
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("1. Switch Account");
                    Console.WriteLine("2. View Transaction Overview and Exit");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Select an option: ");
                    
                    if (int.TryParse(Console.ReadLine(), out int exitChoice))
                    {
                        if (exitChoice == 1)
                        {
                            // Save transactions before switching
                            currentAccount.SaveTransactionsToFile();
                            Console.WriteLine("--------------------------------");
                            continue;
                        }
                    }
                    
                    // View transaction overview and exit
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Overview of your transactions:");
                    foreach (var transaction in currentAccount.ShowTransactions())
                    {
                        Console.WriteLine(transaction);
                    }
                    currentAccount.SaveTransactionsToFile();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    keepRunning = false;
                }
                else
                {
                    Console.WriteLine("Authentication Failed! Too many incorrect attempts. Access denied.");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("1. Try Again");
                    Console.WriteLine("2. Exit");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Select an option: ");
                    
                    if (int.TryParse(Console.ReadLine(), out int retryChoice))
                    {
                        if (retryChoice != 1)
                        {
                            keepRunning = false;
                        }
                    }
                    else
                    {
                        keepRunning = false;
                    }
                    Console.WriteLine("--------------------------------");
                }
            }
        }
    }
}