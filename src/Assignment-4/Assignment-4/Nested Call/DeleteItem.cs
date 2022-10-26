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
        public static void Delete(object item,object primarykey,string? nesteditem=null)
        {
            if(item==null)
            {
                return;
            }
            Type type=item.GetType();

            string? Name = null;
            object? primarykey1 = null;

            PropertyInfo[] property = type.GetProperties();

            List<object> list = new List<object>();
            List<object> GenericList = new List<object>();

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
                    GenericList.Add(property[i]);
                    Name = type.Name;

                }
                else if (property[i].PropertyType.IsClass && property[i].PropertyType != typeof(string))
                {

                    list.Add(property[i]);
                    Name = type.Name;

                }
            }
            
            foreach (var items in list)
            {
                Type type1 = items.GetType();
                DeleteItem.Delete(items, primarykey1,Name);
            }
            foreach (var items in GenericList)
            {
                if (items != null)
                {
                    DeleteItem.Delete(items, primarykey1, Name);
                }
            }

            string p = $"delete from {type.Name} where {nesteditem}Id={primarykey}";
            Connection.ExecuteQuery(p);
        }
    }
}
