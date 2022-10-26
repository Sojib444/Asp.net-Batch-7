using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Nested_Call
{
    public class UpdateItem
    {
        public static void Update(object item)
        {
            if (item == null)
            {
                return;
            }
            Type Mtype = item.GetType();

            string Name = Mtype.Name;

            PropertyInfo[] property = Mtype.GetProperties();
            string s = "";
            string v = "";
            object? primarykey = default;

            List<object> list = new List<object>();
            List<object> GenericList = new List<object>();

            for (int i = 0; i < property.Length; i++)
            {
                if (property[i].Name == "Id")
                {
                    if (property[i] != null)
                    {
                        object? result = property[i].GetValue(item);
                        primarykey = result;
                    }

                }
                if (property[i].PropertyType == typeof(int) || property[i].PropertyType == typeof(double) || property[i].PropertyType == typeof(Guid))
                {
                    if (property[i] != null)
                    {
                        object? result = property[i].GetValue(item);
                        if (result != null)
                        {
                            s += $"{property[i].Name},";
                            v += $"{result},";
                        }
                    }
                }
                else if (property[i].PropertyType == typeof(DateTime))
                {
                    if (property[i] != null)
                    {
                        object? result = property[i].GetValue(item);
                        if (result != null)
                        {
                            s += $"{property[i].Name},";
                            v += $"'{result}',";
                        }
                    }
                }
                else if (property[i].PropertyType == typeof(string))
                {
                    if (property[i] != null)
                    {
                        object? result = property[i].GetValue(item);
                        if (result != null)
                        {
                            s += $"{property[i].Name},";
                            v += $"'{result}',";
                        }
                    }
                }
                else if (property[i].PropertyType.IsGenericType)
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
                else
                {
                    if (property[i].PropertyType.IsClass && property[i].PropertyType != typeof(string))
                    {
                        list.Add(property[i].GetValue(item));
                    }

                }
            }

            string q = s.Remove(s.LastIndexOf(","), 1);
            s = q;
            string t = v.Remove(v.LastIndexOf(","), 1);
            v = t;
            Dictionary<string, object> keyValues = new Dictionary<string, object>();
            string[] arr = s.Split(",");
            string[] brr = v.Split(",");

            for (int i = 0; i < arr.Length; i++)
            {
                keyValues.Add(arr[i], brr[i]);
            }

            string p = "";
            foreach (var items in keyValues)
            {
                p += $"{items.Key}={items.Value},";

            }
            string u = p.Remove(p.LastIndexOf(","), 1);
            p = u;
            string query = $"update {Name} set {p} where Id={primarykey}";
            Connection.UpdateQuery(query);

            foreach (var items in list)
            {
                UpdateItem.Update(items);
            }
            foreach (var items in GenericList)
            {
                UpdateItem.Update(items);
            }
        }
    }
}
