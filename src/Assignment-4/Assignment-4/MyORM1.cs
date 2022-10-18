//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Assignment_4.Nested_Object
//{
//    public class NestestedClass
//    {
//        public static void InsertItem(object item, string value)
//        {
//            Type type1 = item.GetType();
//            string newName = value;
//            PropertyInfo[] property = type1.GetProperties();

//            Dictionary<string, object> parameters = new Dictionary<string, object>();
//            string r = "";

//            Dictionary<object, string> list = new Dictionary<object, string>();
//            Dictionary<object, string> GenericList = new Dictionary<object, string>();

//            for (int i = 0; i < property.Length; i++)
//            {
//                if (property[i].PropertyType == typeof(DateTime) || property[i].PropertyType == typeof(int) || property[i].PropertyType == typeof(double) || property[i].PropertyType == typeof(Guid))
//                {
//                    object? result = property[i].GetValue(item);
//                    string n = property[i].Name;
//                    parameters.Add($"{n}", result);
//                    r += $"@{n},";

//                }
//                else if (property[i].PropertyType == typeof(string))
//                {
//                    object? result = property[i].GetValue(item);
//                    string n = property[i].Name;

//                    parameters.Add($"{n}", result);
//                    r += $"@{n},";
//                }
//                else if (property[i].PropertyType.IsGenericType)
//                {
//                    object result = property[i].GetValue(item);
//                    foreach (var items in result as IList)
//                    {
//                        GenericList.Add(items, property[i].Name);

//                    }
//                }
//                else
//                {
//                    list.Add(property[i].GetValue(item), property[i].Name);
//                }

//            }
//            string p = $"insert into {newName} values ({r})";
//            Connection.InsertCommand(p, parameters);
//            foreach (var items in list)
//            {
//                InsertItem(items.Key, items.Value);
//            }
//            foreach (var items in GenericList)
//            {
//                InsertItem(items.Key, items.Value);
//            }
//        }
//    }
//}
