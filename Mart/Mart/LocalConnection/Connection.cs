using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Marts
{
     public class Connection
    { 
        public static SqlConnection getConnection()
        {
            string conString = @"Data Source=INTERGER\INTERGER;Initial Catalog=Mart;Integrated Security=True";
            return new SqlConnection(conString);
        }
    }
}
