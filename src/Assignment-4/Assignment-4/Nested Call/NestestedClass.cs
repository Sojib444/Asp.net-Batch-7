using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_4.Nested_Object
{
    public class NestestedClass
    {
        public static void InsertItem(object item,object primarykey,Type? Gtype=null)
        {
            if(item==null)
            {
                return;
            }
            Type type1 = item.GetType();
            string newName = type1.Name;
            PropertyInfo[] property = type1.GetProperties();

            object? primarykey1 = default;

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string r = "";

            List<object> list = new List<object>();
            List<object> GenericList =new  List<object>();

            for (int i = 0; i < property.Length; i++)
            {
                if (property[i].Name == "Id")
                {
                    if (property[i] != null)
                    {
                        object? result = property[i].GetValue(item);
                        primarykey1 = result;
                    }

                }
                if (property[i].PropertyType == typeof(DateTime)|| property[i].PropertyType == typeof(int) || property[i].PropertyType == typeof(double))
                {
                    if (property[i] != null)
                    {
                        object? result = property[i].GetValue(item);
                        string n = property[i].Name;
                        parameters.Add($"{n}", result);
                        r += $"@{n},";
                    }

                }
                else if (property[i].PropertyType == typeof(DateTime))
                {
                    if (property[i] != null)
                    {
                        object? result = property[i].GetValue(item);
                        string n = property[i].Name;
                        parameters.Add($"{n}", result);
                        r += $"@'{n}',";
                    }
                }
                else if (property[i].PropertyType == typeof(string))
                {
                    if (property[i] != null)
                    {
                        object? result = property[i].GetValue(item);
                        string n = property[i].Name;

                        parameters.Add($"{n}", result);
                        r += $"@{n},";
                    }
                }
                else if (property[i].PropertyType.IsGenericType)
                {
                    if (property[i] != null)
                    {
                        object result = property[i].GetValue(item);
                        if (result != null)
                        {
                            foreach (var items in result as IList)
                            {
                                GenericList.Add(items);

                            }
                        }
                    }
                }
                else
                {
                    if (property[i] != null)
                    {
                        list.Add(property[i].GetValue(item));
                    }
                }

            }

            if (Gtype == typeof(int))
            {
                int test = int.Parse(string.Format("{0}", primarykey));
                r += $"{test},";

            }
            else if (Gtype == typeof(double))
            {
                double test = double.Parse(string.Format("{0}", primarykey));
                r += $"{test},";
            }
            else if(Gtype == typeof(Guid))
            {
                Guid test = Guid.Parse(string.Format("{0}", primarykey));
                r += $"{test},";
            }       

            string p = $"insert into {newName} values ({r})";
            Connection.InsertCommand(p, parameters);
            foreach (var items in list)
            {
                InsertItem(items,primarykey1,Gtype);
            }
            foreach (var items in GenericList)
            {
                InsertItem(items,primarykey1,Gtype);
            }
        }
    }
}
