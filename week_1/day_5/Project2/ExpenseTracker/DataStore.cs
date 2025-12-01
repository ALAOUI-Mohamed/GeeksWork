using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

public static class DataStore
{
    private const string FileName = "transactions.json";

    // Save transactions to JSON file
    public static void Save(List<Transaction> transactions)
    {
        string json = JsonSerializer.Serialize(transactions, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FileName, json);
    }

    // Load transactions from JSON file
    public static List<Transaction> Load()
    {
        if (!File.Exists(FileName))
            return new List<Transaction>();

        string json = File.ReadAllText(FileName);
        return JsonSerializer.Deserialize<List<Transaction>>(json);
    }
}