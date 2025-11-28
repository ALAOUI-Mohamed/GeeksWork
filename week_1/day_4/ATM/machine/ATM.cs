using System;
using System.Collections.Generic;

namespace ATMMachine
{
    class ATM
    {
        private const int MAX_PIN_ATTEMPTS = 3;

        public Account Authenticate(List<Account> accounts)
        {
            int attempts = 0;
            while (attempts < MAX_PIN_ATTEMPTS)
            {
                Console.WriteLine($"Attempt {attempts + 1} of {MAX_PIN_ATTEMPTS}");
                Console.WriteLine("Please enter your Account Number:");
                string enteredAccountNumber = Console.ReadLine();
                Console.WriteLine("Please enter your PIN:");
                
                if (!int.TryParse(Console.ReadLine(), out int enteredPIN))
                {
                    Console.WriteLine("Invalid PIN format. Please enter numbers only.");
                    attempts++;
                    continue;
                }

                // Check credentials against accounts list
                foreach (var account in accounts)
                {
                    if (enteredAccountNumber == account.AccountNumber && enteredPIN == account.PIN)
                    {
                        return account;
                    }
                }

                attempts++;
                if (attempts < MAX_PIN_ATTEMPTS)
                {
                    Console.WriteLine($"Invalid credentials. {MAX_PIN_ATTEMPTS - attempts} attempt(s) remaining.");
                    Console.WriteLine("--------------------------------");
                }
            }
            return null;
        }

        public void ShowMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("ATM Main Menu:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Show Transactions");
            Console.WriteLine("5. Save Transactions to File");
            Console.WriteLine("6. Next Interest Payout Amount");
            Console.WriteLine("7. Exit");
            Console.WriteLine("--------------------------------");
        }

        public void PerformAction(Account account, int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine(account.CheckBalance());
                    break;
                case 2:
                    Console.WriteLine("Enter amount to deposit:");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(depositAmount);
                    Console.WriteLine("Deposit Successful!");
                    Console.WriteLine(account.CheckBalance());
                    break;
                case 3:
                    Console.WriteLine("Enter amount to withdraw:");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    if (account.Withdraw(withdrawAmount))
                    {
                        Console.WriteLine("Withdrawal Successful!");
                        Console.WriteLine(account.CheckBalance());
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance!");
                        Console.WriteLine(account.CheckBalance());
                    }
                    break;
                case 4:
                    List<string> transactions = account.ShowTransactions();
                    Console.WriteLine("Transaction History:");
                    foreach (var transaction in transactions)
                    {
                        Console.WriteLine(transaction);
                    }
                    break;
                case 5:
                    account.SaveTransactionsToFile();
                    break;
                case 6:
                    Console.WriteLine(account.Interest());
                    break;
                case 7:
                    Console.WriteLine("Money will not multiply by itself. Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}