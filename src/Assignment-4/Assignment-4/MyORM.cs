using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Collections.Specialized;
using System.Collections;

namespace Assignment_4
{
    public class MyORM<G, T> : Iorm<G, T> where T : class, IGuid<G>
    {
        public void Insert(T item)
        {

            Type type = item.GetType();

           PropertyInfo[] property=type.GetProperties();

            string p = "";
            for (int i = 0; i <property.Length;i++)
            {
                //check guid incomple;
                if (property[i].PropertyType==typeof(int) || property[i].PropertyType == typeof(double)|| property[i].PropertyType == typeof(Guid))
                {
                    object? result =property[i].GetValue(item);
                    if(i!=property.Length-1)
                    {
                        p += $"{result},";
                    }
                    else
                    {
                        p += $"{result}";
                    }


                }
                else if (property[i].PropertyType == typeof(string) )
                {
                    object? result = property[i].GetValue(item);
                    if (i != property.Length - 1)
                    {
                        p += $"'{result}',";
                    }
                    else
                    {
                        p += $"'{result}'";
                    }


                }

                else if (property[i].PropertyType.IsClass && !property[i].PropertyType.IsGenericType)
                {
                    Insert(property[i].GetValue());
                }
                else if (property[i].PropertyType.IsGenericType)
                {
                    object obj=property[i].GetValue(item);
                    foreach(var prop in obj as IList)
                    {

                        var result = prop;
                        object ob=Convert.ChangeType(result, typeof(T));
                        Insert((T)ob);
                    }
                }

            }

            if(p[p.Length-1]==',')
            {
                string q=p.Remove(p.Length - 1, 1);
                p = q;
            }
            string s = $"insert into {type.Name} values ({p}) ";
            Console.WriteLine(s);
            using var connection = Connection.Getconnection();
            using SqlCommand sqlCommand = new SqlCommand(s, connection);
            try
            {
                int result=sqlCommand.ExecuteNonQuery();
                if(result==1)
                {
                    Console.WriteLine("Insert Succesfull");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(G id)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(G id)
        {
            throw new NotImplementedException();
        }

       

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
