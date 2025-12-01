using System;

public class Transaction
{
    public int Id { get; set; }             // Unique ID
    public string Title { get; set; }       // Description
    public decimal Amount { get; set; }     // Positive = Income, Negative = Expense
    public string Category { get; set; }    // Category name
    public DateTime Date { get; set; }      // Transaction date
}