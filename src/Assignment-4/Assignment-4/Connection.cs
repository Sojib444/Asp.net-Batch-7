using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Connection
    {

        public static SqlConnection Getconnection()
        {
           string connectionString = "Server=DESKTOP-9P36ISK\\SQLEXPRESS;Database=Exam4;Trusted_Connection=True;"; ;
        SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                    //Console.WriteLine("Connection Successfull");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sqlConnection;
        }

    }
}
