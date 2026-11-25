using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace property_portfolio_manager.Data
{
    internal static class DatabasePaths
    {
        public static string DirectoryPath => 
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "PropertyPortfolioManager");

        public static string FilePath =>
            Path.Combine(DirectoryPath, "portfolio.db");
    }
}
