using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staj_proje.Classes
{
    internal class SqlOperations
    {                
            public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stajproje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            public static void CheckConnection(SqlConnection connection)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                else
                {

                }
            }
    }




}
