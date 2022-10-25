using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Nested_Call
{
    public class DeleteItem
    {
        public static void Delete(object item,object primarykey)
        {
            Type type=item.GetType();

            string Name = type.Name;

            PropertyInfo[] property = type.GetProperties();

            List<object> list = new List<object>();
            List<object> GenericList = new List<object>();

            object? primarykey1 = default;

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
                if (property[i].PropertyType.IsGenericType)
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
                else if (property[i].PropertyType.IsClass && property[i].PropertyType != typeof(string))
                {
                    if (property[i] != null)
                    {
                        list.Add(property[i].GetValue(item));
                    }
                }
            }

            foreach (var items in list)
            {
                if (items != null)
                {
                    DeleteItem.Delete(items, primarykey1);
                }
            }
            foreach (var items in GenericList)
            {
                if (items != null)
                {
                    DeleteItem.Delete(items, primarykey1);
                }
            }

            string p = $"delete from {Name} where {Name}Id={primarykey}";
            Connection.ExecuteQuery(p);
        }
    }
}
