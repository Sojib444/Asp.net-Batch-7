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
using System.Xml.Linq;
using Assignment_4.Nested_Object;

namespace Assignment_4
{
    public class MyORM<G, T> : Iorm<G, T> where T : class, IGuid<G>
    {
        public void Insert(T item)
        {
            Type Mtype = item.GetType();

            string Name = Mtype.Name;

            PropertyInfo[] property =Mtype.GetProperties();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string r = "";
            object? primarykey=default;

            List<object> list = new List<object>();
            List<object> GenericList = new List<object>();

            for (int i=0;i<property.Length;i++)
            {
                if (property[i].Name=="Id")
                {
                    object? result = property[i].GetValue(item);
                    primarykey = result;
                    
                }
                if (property[i].PropertyType == typeof(int) || property[i].PropertyType == typeof(double) || property[i].PropertyType == typeof(Guid))
                {
                    object? result = property[i].GetValue(item);
                    string n = property[i].Name;
                    parameters.Add($"{n}", result);
                    r += $"@{n},";

                }
                else if( property[i].PropertyType == typeof(DateTime))
                {
                    object? result = property[i].GetValue(item);
                    string n = property[i].Name;
                    parameters.Add($"{n}", result);
                    r += $"@{n},";
                }
                else if (property[i].PropertyType == typeof(string))
                {
                    object? result = property[i].GetValue(item);
                    string n = property[i].Name;

                    parameters.Add($"{n}", result);
                    r += $"@{n},";
                }
                else if (property[i].PropertyType.IsGenericType)
                {
                    object result = property[i].GetValue(item);
                    foreach(var items in result as IList)
                    {
                        GenericList.Add(items);
                    }
                }
                else
                {
                    list.Add(property[i].GetValue(item));
                    
                }
               
            }

            Type GType = typeof(G);
            string p = $"insert into {Name} values ({r})";
            Connection.InsertCommand(p, parameters);
            foreach(var items  in list)
            {
                NestestedClass.InsertItem(items,primarykey, GType);
            }
            foreach (var items in GenericList)
            {
                NestestedClass.InsertItem(items,primarykey, GType);
            }
        }
        public void Delete(T item)
        {
            /*Type type = typeof(T);
            string Name = type.Name;

            PropertyInfo[] property= type.GetProperties();

            for (int i = 0; i < property.Length; i++)
            {
                
                else if (property[i].PropertyType.IsGenericType)
                {
                    object result = property[i].GetValue(item);
                    foreach (var items in result as IList)
                    {
                        GenericList.Add(items);
                    }
                }
                else
                {
                    list.Add(property[i].GetValue(item));
                }

            }
            string p = $"insert into {Name} values ({r})";
            Connection.InsertCommand(p, parameters);
            foreach (var items in list)
            {
                NestestedClass.InsertItem(items);
            }
            foreach (var items in GenericList)
            {
                NestestedClass.InsertItem(items);
            }*/




        }

        public void Delete(G id)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            //object item = T as object;
            Type type = typeof(T);
            object t = typeof(T);
            void getObject(object item )
            {

            }

            getObject(t);


            string newName = type.Name;
            string fullName = type.FullName;
            
            Console.WriteLine(newName);
            string query = $"select * from {newName}";
            string getString = "";
            using SqlDataReader dataReader = Connection.ExecuteQuery(query);
            if(dataReader.HasRows)
            {
                while(dataReader.Read())
                {
                    string values = "";
                    for(int i=0;i<dataReader.FieldCount;i++)
                    {
                        values += $"{dataReader[i]},";
                    }

                    PropertyInfo[] property = type.GetProperties();
                    string para = "";

                    for (int i = 0; i < property.Length; i++)
                    {
                        if (property[i].PropertyType == typeof(DateTime) || property[i].PropertyType == typeof(int) || property[i].PropertyType == typeof(double) || property[i].PropertyType == typeof(Guid))
                        {
                            string Name = property[i].Name;
                            para += $"{Name},";

                        }
                        else if (property[i].PropertyType == typeof(string))
                        {
                            string Name = property[i].Name;

                            para += $"{Name},";
                        }
                        else if (property[i].PropertyType.IsGenericType)
                        {
                            object result = property[i].GetValue(fullName);
                            foreach (var items in result as IList)
                            {
                                
                            }

                        }

                    }
                    int d = para.LastIndexOf(",");
                    string q = para.Remove(d, 1);
                    para = q;

                    int c = values.LastIndexOf(",");
                    string f = values.Remove(c, 1);
                    values = f;


                    string[] DName = para.Split(",");
                    string[] Dvalues = values.Split(",");

                    Dictionary<string, string> keyValue = new Dictionary<string, string>();

                    for(int i=0;i<DName.Length;i++)
                    {
                        keyValue.Add(DName[i], Dvalues[i]);
                    }

                    foreach(var item in keyValue)
                    {
                        getString += item.Key + " : " + item.Value + "\n";
                        
                    }



                }
            }
            //int d = r.LastIndexOf(",");
            //string q=r.Remove(d, 1);
            //r = q;
            //string p = $"Select {r} from {newName}";
            Console.WriteLine(getString);
            
        }

        public void GetById(G id)
        {
           Type type=typeof(T);
            string name=type.Name;
            Console.WriteLine(name);

               
        }

       

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}

/*if (i != property.Length - 1)
{
    p += $"{result},";
}
else
{
    p += $"{result}";

}
*/
