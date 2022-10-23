using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Nested_Object
{
    public class GetAll
    {
        public static void GetAllvalues(object item)
        {
            Type type1 = item.GetType();
            string newName = type1.Name;
            PropertyInfo[] property = type1.GetProperties();
            string r = "";

            for (int i = 0; i < property.Length; i++)
            {
                if (property[i].PropertyType == typeof(DateTime) || property[i].PropertyType == typeof(int) || property[i].PropertyType == typeof(double) || property[i].PropertyType == typeof(Guid))
                {
                    string Name=property[i].Name;
                    r += $"{ Name},";

                }
                else if (property[i].PropertyType == typeof(string))
                {
                    string Name = property[i].Name;

                    r += $"{Name},";
                }
                

            }
            string p = $"Select {r} from {newName}";
            Connection.ExecuteQuery(p);

        }
    }
    
}


//else if (property[i].PropertyType.IsGenericType)
//{
//    object result = property[i].GetValue(item);
//    foreach (var items in result as IList)
//    {
//        // GenericList.Add(items);

//    }
//}
//else
//{
//    //list.Add(property[i].GetValue(item));
//}
