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

        public static void InsertCommand(string p,Dictionary<string,object> parameters)
        {

            if (p[p.Length - 2] == ',')
            {
                string q = p.Remove(p.Length - 2, 1);
                p = q;
            }
            using var connection = Getconnection();
            using SqlCommand sqlCommand = new SqlCommand(p, connection);
            
            if(parameters!=null)
            {
                foreach(var item in parameters)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
            }
            try
            {
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("Insert Succesfull");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
