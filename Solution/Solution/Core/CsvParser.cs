using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace PersonalFinanceManager.Core
{
    /// <summary>
    /// CSV parser for semicolon-delimited transaction files.
    /// Expected header (optional): Date;Description;Amount;Currency;Category
    /// Date format: yyyy-MM-dd 
    /// On malformed lines, we optionally return an error entry or throw depending on mode.
    /// </summary>
    
    public static class CsvParser
    {

    }

}
