using System;
using System.Collections.Generic;
using System.IO;

namespace ATMMachine
{
    class Account
    {
        public string AccountNumber { get; set; }
        public int PIN { get; set; }
        public double Balance { get; set; }
        public List<string> Transactions { get; set; }
        private const double year_int_rate = 0.025;
        private const string TRANSACTIONS_FILE = "transactions.txt";

        public Account(string accountNumber, int pin, double initialBalance)
        {
            AccountNumber = accountNumber;
            PIN = pin;
            Balance = initialBalance;
            Transactions = new List<string>();
            Transactions.Add($"Account created with initial balance: ${initialBalance}");
        }

        public string CheckBalance()
        {
            Transactions.Add("Checked Balance");
            return $"Your current balance is: ${Balance:F2}";
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                double interest = amount * year_int_rate / 4; // Quarterly interest
                Transactions.Add($"Deposited: ${amount:F2} | Additional interest earned on the next quarterly pay out : ${interest:F2}");
            }
        }

        public string Interest()
        {
            double interest = Balance * year_int_rate / 4; // Quarterly interest
            return $"Total interest on the next quarterly pay out : ${interest:F2}";
        }

        public bool Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return false;
            }
            Balance -= amount;
            Transactions.Add($"Withdrew: ${amount:F2}");
            return true;
        }

        public List<string> ShowTransactions()
        {
            return Transactions;
        }

        public void SaveTransactionsToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(TRANSACTIONS_FILE, true))
                {
                    writer.WriteLine($"\n=== Account: {AccountNumber} ===");
                    writer.WriteLine($"Final Balance: ${Balance:F2}");
                    writer.WriteLine("Transaction History:");
                    foreach (var transaction in Transactions)
                    {
                        writer.WriteLine($"  - {transaction}");
                    }
                    writer.WriteLine($"Saved at: {DateTime.Now}");
                }
                Console.WriteLine("Transactions saved to file successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving transactions: {ex.Message}");
            }
        }
    }
}