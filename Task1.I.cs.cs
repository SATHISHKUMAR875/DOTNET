using System;

class TransactionAnalyzer
{
    static void Main()
    {
        // Declaring variables with appropriate datatypes

        string transactionId = "AB12CD34EF56";      // 12-character alphanumeric
        decimal amount = 1000000.75m;               // Money values → decimal
        bool isInternational = true;                // True/False
        decimal customerRating = 4.75m;             // Rating with 2 decimal precision
        DateTime transactionTimestamp = DateTime.Now; // Current date & time
        long rewardPoints = 2500000;                // Large whole number

        // Display the transaction details
        Console.WriteLine("Transaction Details:");
        Console.WriteLine("Transaction ID: " + transactionId);
        Console.WriteLine("Amount: ₹" + amount);
        Console.WriteLine("International: " + isInternational);
        Console.WriteLine("Customer Rating: " + customerRating);
        Console.WriteLine("Timestamp: " + transactionTimestamp);
        Console.WriteLine("Reward Points: " + rewardPoints);

        Console.ReadLine();
    }
}