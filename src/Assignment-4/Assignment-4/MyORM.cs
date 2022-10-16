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

            Dictionary<object,string> list = new Dictionary<object, string>();
            Dictionary<object,string> GenericList = new Dictionary<object, string>();

            for (int i=0;i<property.Length;i++)
            {
                if (property[i].PropertyType == typeof(int) || property[i].PropertyType == typeof(double) || property[i].PropertyType == typeof(Guid) || property[i].PropertyType == typeof(DateTime))
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
                        GenericList.Add(items, property[i].Name);
                    }
                }
                else
                {
                    list.Add(property[i].GetValue(item), property[i].Name); 
                }
               
            }
            string p = $"insert into {Name} values ({r})";
            Connection.InsertCommand(p, parameters);
            foreach(var items  in list)
            {
                NestestedClass.InsertItem(items.Key,items.Value);
            }
            foreach (var items in GenericList)
            {
                NestestedClass.InsertItem(items.Key, items.Value);
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

/*if (i != property.Length - 1)
{
    p += $"{result},";
}
else
{
    p += $"{result}";

}
*/
