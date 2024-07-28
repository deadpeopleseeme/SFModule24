using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Data Source=.\SQLEXPRESS;Database=testing;Trusted_Connection=True;";
    }
}
