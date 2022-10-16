using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*
namespace Assignment_4
{
    public class MyORM1 :
    {
        Type type = item1.GetType();
        string Name = type.Name;

        void insetItem(object item)
        {
            Type type1 = item.GetType();

            PropertyInfo[] property = type1.GetProperties();

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string r = "";
            for (int i = 0; i < property.Length; i++)
            {
                //check guid incomple;
                if (property[i].PropertyType == typeof(int) || property[i].PropertyType == typeof(double) || property[i].PropertyType == typeof(Guid))
                {
                    object? result = property[i].GetValue(item1);
                    string n = property[i].Name;
                    parameters.Add($"{n}", result);

                    if (i != property.Length - 1)
                    {
                        r += $"@{n},";
                    }
                    else
                    {
                        r += $"@{n}";

                    }

                }
                else if (property[i].PropertyType == typeof(string))
                {
                    object? result = property[i].GetValue(item1);
                    string n = property[i].Name;

                    parameters.Add($"{n}", result);

                    if (i != property.Length - 1)
                    {
                        r += $"@{n},";
                    }
                    else
                    {
                        r += $"@{n}";

                    }
                }
                else if (property[i].PropertyType.IsClass)
                {
                    Name = property[i].Name;
                    var result = property[i].GetValue(property[i]);
                    insetItem(result);

                }
                else if (property[i].PropertyType.IsGenericType)
                {
                    Name = property[i].Name;
                    object obj = property[i].GetValue(item);
                    foreach (var prop in obj as IList)
                    {
                        insetItem(prop);
                    }
                }

            }
            string p = $"insert into {Name} values ({r}) ";
            Console.WriteLine(Name);
            Connection.InsertCommand(p, parameters);
        }
        insetItem(type);
    }
*/

/*void InsertItem(object item1)
            {
                string nname = Name;
                Type type = item1.GetType();
                PropertyInfo[] property= type.GetProperties();

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                string r = "";
                for (int i = 0; i < property.Length; i++)
                {
                    //check guid incomple;
                    if (property[i].PropertyType == typeof(int) || property[i].PropertyType == typeof(double) || property[i].PropertyType == typeof(Guid))
                    {
                        object? result = property[i].GetValue(item1);
                        string n = property[i].Name;
                        parameters.Add($"{n}", result);

                        if (i != property.Length - 1)
                        {
                            r += $"@{n},";
                        }
                        else
                        {
                            r += $"@{n}";

                        }

                    }
                    else if (property[i].PropertyType == typeof(string))
                    {
                        object? result = property[i].GetValue(item1);
                        string n = property[i].Name;

                        parameters.Add($"{n}", result);

                        if (i != property.Length - 1)
                        {
                            r += $"@{n},";
                        }
                        else
                        {
                            r += $"@{n}";

                        }
                    }
                    else if (property[i].PropertyType.IsClass)
                    {

                        Name = property[i].Name;
                        var result = property[i].GetValue(item1);
                        InsertItem(result);

                    }
                }
                string p = $"insert into {nname} values ({r})";
                Connection.InsertCommand(p, parameters);

            } */