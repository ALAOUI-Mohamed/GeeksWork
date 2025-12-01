using System;
using System.Collections.Generic;
using System.Linq;

public class TransactionManager
{
    private List<Transaction> transactions = new List<Transaction>();
    private int nextId = 1;

    // Add new transaction
    public void AddTransaction(string title, decimal amount, string category, DateTime date)
    {
        transactions.Add(new Transaction
        {
            Id = nextId++,
            Title = title,
            Amount = amount,
            Category = category,
            Date = date
        });
    }

    // Get all transactions
    public List<Transaction> GetAll()
    {
        return transactions;
    }

    // Find a transaction by ID
    public Transaction GetById(int id)
    {
        return transactions.FirstOrDefault(t => t.Id == id);
    }

    // Update a transaction
    public bool UpdateTransaction(int id, string title, decimal amount, string category, DateTime date)
    {
        var tr = GetById(id);
        if (tr == null) return false;

        tr.Title = title;
        tr.Amount = amount;
        tr.Category = category;
        tr.Date = date;
        return true;
    }

    // Delete a transaction
    public bool DeleteTransaction(int id)
    {
        var tr = GetById(id);
        if (tr == null) return false;

        transactions.Remove(tr);
        return true;
    }

    // Summary calculations
    public decimal TotalIncome() => transactions.Where(t => t.Amount > 0).Sum(t => t.Amount);
    public decimal TotalExpenses() => transactions.Where(t => t.Amount < 0).Sum(t => Math.Abs(t.Amount));
    public decimal Balance() => TotalIncome() - TotalExpenses();

    // Expenses grouped by category
    public IEnumerable<IGrouping<string, Transaction>> ExpensesByCategory()
    {
        return transactions
            .Where(t => t.Amount < 0)
            .GroupBy(t => t.Category);
    }
}