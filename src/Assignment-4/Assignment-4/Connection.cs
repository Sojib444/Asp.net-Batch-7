using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace Assignment_4
{
    public class Connection
    {
        public static SqlConnection Getconnection()
        {
           string connectionString = "Server=DESKTOP-9P36ISK\\SQLEXPRESS;Database=Test2;Trusted_Connection=True;"; ;
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

        public static void ExecuteQuery(string  p)
        {
            try
            {
                var connection = Getconnection();
                SqlCommand sqlCommand = new SqlCommand(p, connection);
                int n=sqlCommand.ExecuteNonQuery();
                if(n==1)
                {
                    Console.WriteLine("Delete Successful");
                }

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        public static void DeleteQuery(string p)
        {

            try
            {
                var connection = Getconnection();
                SqlCommand sqlCommand = new SqlCommand(p, connection);
                SqlDataReader? reader1 = sqlCommand.ExecuteReader();

                //if (reader.HasRows)
                //{

                //    while(reader.Read())
                //    {
                //        for(int i=0;i<reader.FieldCount;i++)
                //        {
                //            Console.Write(reader[i]+" ");

                //        }
                //        Console.WriteLine();
                //    }
                //}


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }


        public static object IdInfo(string p)
        {
            object id = 0;
            try
            {
                var connection = Getconnection();
                SqlCommand sqlCommand = new SqlCommand(p, connection);
                SqlDataReader? reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        id = reader[0];
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return id;

        }

    }
}
