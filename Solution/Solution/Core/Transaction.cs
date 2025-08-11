using System;
using System.Globalization;

namespace PersonalFinanceManager.Core
{
    /// <summary>
    /// Represents a single financial transaction in the personal finance manager system.
    /// </summary>
    public class  Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; } = "NONE";
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "EUR";
        public string Category { get; set; } = "Uncategorized";
        public string SourceFile { get; set; } = string.Empty;


        public override string ToString()
             => $"{Date:yyyy-MM-dd} | {Amount,10:0.00} {Currency} | {Category} | {Description}";
    }
}