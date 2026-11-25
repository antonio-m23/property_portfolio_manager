using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace property_portfolio_manager.Data
{
    internal static class DatabaseConnectionFactory
    {
        public static SqliteConnection Create()
        {
            var connectionString = new SqliteConnectionStringBuilder
            {
                DataSource = DatabasePaths.FilePath,
                Mode = SqliteOpenMode.ReadWriteCreate,
                ForeignKeys = true
            }.ToString();

            return new SqliteConnection(connectionString);
        }
    }
}
