using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public static class ExtensionString
    {
        public static string DevolverConnectionString(this string db)
        {
            string server = @"Server=localhost\SQLEXPRESS;";
            string database = db;
            string connection = "Trusted_Connection=True;";

            string connectionString = server + database + connection;

            return connectionString;

        }
    }
}
