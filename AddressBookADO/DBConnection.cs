using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO
{
    public class DBConnection
    {
        
        public SqlConnection GetConnection()
        {
            /// Specifying the connectionString from the sql server connection.
            string connectiongString = @"Data Source=LAPTOP-NAVJ6800\SQLEXPRESS;Initial Catalog=AddressBook;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectiongString);
            return connection;
        }
    }
}
