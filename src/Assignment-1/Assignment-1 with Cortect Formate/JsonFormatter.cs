using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;


namespace Assignment
{
    public class JsonFormatter
    {

        public static string Json="";

        public static string Convert(object item)
        {

            if (item == null)
            {
                return null;
            }
            Type type = item.GetType();

            Json += "{ \n ";

            PropertyInfo[] ptypes = type.GetProperties();

            for (int i = 0; i < ptypes.Length; i++)
            {
                if (ptypes[i].PropertyType.IsPrimitive)
                {
                    if (ptypes[i].PropertyType == typeof(int))
                    {
                        object checck_value = ptypes[i].GetValue(item);
                        int d = (int)checck_value;

                        if (d != 0)
                        {
                            Json += $"\"{ptypes[i].Name}\" :";
                            object? value = ptypes[i].GetValue(item);

                            Json += $" {value}";
                            if (i != ptypes.Length - 1)
                            {
                                Json += ", \n";
                            }
                            else
                            {
                                Json += "\n";
                            }
                        }
                    }
                    else if (ptypes[i].PropertyType == typeof(double))
                    {
                        object checck_value = ptypes[i].GetValue(item);
                        double d = (double)checck_value;

                        if (d != 0)
                        {
                            Json += $"\"{ptypes[i].Name}\" :";
                            object? value = ptypes[i].GetValue(item);

                            Json += $" {value}";
                            if (i != ptypes.Length - 1)
                            {
                                Json += ", \n";
                            }
                            else
                            {
                                Json += "\n";
                            }
                        }
                    }
                    else if (ptypes[i].PropertyType == typeof(float))
                    {
                        object checck_value = ptypes[i].GetValue(item);
                        float d = (float)checck_value;

                        if (d != 0)
                        {
                            Json += $"\"{ptypes[i].Name}\" :";
                            object? value = ptypes[i].GetValue(item);

                            Json += $" {value}";
                            if (i != ptypes.Length - 1)
                            {
                                Json += ", \n";
                            }
                            else
                            {
                                Json += "\n";
                            }
                        }
                    }


                }
                else if (ptypes[i].PropertyType == typeof(string))
                {
                    object checck_value = ptypes[i].GetValue(item);

                    if (checck_value != null)
                    {
                        Json += $"\"{ptypes[i].Name}\" : ";
                        object? value = ptypes[i].GetValue(item);

                        Json += $"\"{value}\"";
                        if (i != ptypes.Length - 1)
                        {
                            Json += ", \n";
                        }
                        else
                        {
                            Json += "\n";
                        }

                    }
                    
                }
                else if (ptypes[i].PropertyType.IsArray)
                {
                    if (ptypes[i].PropertyType == typeof(int[]))
                    {
                        int[] arr = (int[])ptypes[i].GetValue(item);
                        if (arr != null)
                        {
                            Json += $"\"{ptypes[i].Name}\" : [ ";
                            for (int j = 0; j < arr.Length; j++)
                            {
                                Json += $" {arr[j]}";
                                if (j != arr.Length - 1)
                                {
                                    Json += ", ";
                                }
                                else
                                {
                                    if (i != ptypes.Length - 1)
                                    {
                                        Json += "], \n";
                                    }
                                    else
                                    {
                                        Json += "] \n";
                                    }
                                }
                            }
                        }
                    }
                    else if (ptypes[i].PropertyType == typeof(double[]))
                    {
                        double[] arr = (double[])ptypes[i].GetValue(item);
                        if (arr != null)
                        {
                            Json += $"\"{ptypes[i].Name}\" : [ ";
                            for (int j = 0; j < arr.Length; j++)
                            {
                                Json += $" {arr[j]}";
                                if (j != arr.Length - 1)
                                {
                                    Json += ", ";
                                }
                                else
                                {
                                    if (i != ptypes.Length - 1)
                                    {
                                        Json += "], \n";
                                    }
                                    else
                                    {
                                        Json += "] \n";
                                    }
                                }
                            }
                        }
                    }
                    else if (ptypes[i].PropertyType == typeof(string[]))
                    {
                        string[] arr = (string[])ptypes[i].GetValue(item);
                        if (arr != null)
                        {
                            Json += $"\"{ptypes[i].Name}\" : [ ";
                            for (int j = 0; j < arr.Length; j++)
                            {
                                Json += $" \"{arr[j]}\"";
                                if (j != arr.Length - 1)
                                {
                                    Json += ", ";
                                }
                                else
                                {
                                    if (i != ptypes.Length - 1)
                                    {
                                        Json += "], \n";
                                    }
                                    else
                                    {
                                        Json += "] \n";
                                    }
                                }
                            }
                        }
                    }
                    else if (ptypes[i].PropertyType == typeof(char[]))
                    {
                        char[] arr = (char[])ptypes[i].GetValue(item);
                        if (arr != null)
                        {
                            Json += $"\"{ptypes[i].Name}\" : [ ";
                            for (int j = 0; j < arr.Length; j++)
                            {
                                Json += $" \'{arr[j]}\'";
                                if (j != arr.Length - 1)
                                {
                                    Json += ", ";
                                }
                                else
                                {
                                    if (i != ptypes.Length - 1)
                                    {
                                        Json += "], \n";
                                    }
                                    else
                                    {
                                        Json += "] \n";
                                    }
                                }
                            }
                        }
                    }
                    else if (ptypes[i].PropertyType == typeof(DateTime[]))
                    {
                        DateTime[] arr = (DateTime[])ptypes[i].GetValue(item);
                        if (arr != null)
                        {
                            Json += $"\"{ptypes[i].Name}\" : [ ";
                            for (int j = 0; j < arr.Length; j++)
                            {
                                Json += $" \"{arr[j]}\"";
                                if (j != arr.Length - 1)
                                {
                                    Json += ", ";
                                }
                                else
                                {
                                    if (i != ptypes.Length - 1)
                                    {
                                        Json += "], \n";
                                    }
                                    else
                                    {
                                        Json += "] \n";
                                    }
                                }
                            }
                        }
                    }
                }
                else if (ptypes[i].PropertyType == typeof(DateTime))
                {
                    object checck_value = ptypes[i].GetValue(item);

                    if (checck_value != null)
                    {
                        Json += $" \"{ptypes[i].Name} \" : ";
                        object? value = ptypes[i].GetValue(item);

                        Json += $" \"{value}\"";
                        if (i != ptypes.Length - 1)
                        {
                            Json += ", \n";
                        }
                        else
                        {
                            Json += "\n";
                        }
                    }

                }
                else if (ptypes[i].PropertyType.IsClass && !ptypes[i].PropertyType.IsGenericType)
                {
                    object checck_value = ptypes[i].GetValue(item);

                    if (checck_value != null)
                    {
                        Json += $"\"{ptypes[i].Name}\" : ";

                        Convert(ptypes[i].GetValue(item));

                        if (i != ptypes.Length - 1)
                        {
                            Json += ",\n";
                        }
                    }


                }

                else if (ptypes[i].PropertyType.IsGenericType)
                {
                    object checck_value = ptypes[i].GetValue(item);

                    if (checck_value != null)
                    {
                        Json += $"\"{ptypes[i].Name}\" : [ \n";
                        object obj = ptypes[i].GetValue(item);
                        foreach (var items in obj as IList)
                        {

                            Convert(items);

                            Json += ",";

                        }
                        string bson = Json.Remove(Json.Length - 1);
                        Json = bson;

                        if (i != ptypes.Length - 1)
                        {
                            Json += "], \n";
                        }
                        else
                        {
                            Json += "] \n";
                        }

                       
                    }
                    
                }



            }
            Json += "}";
            




            return Json;

        }
    }
}




