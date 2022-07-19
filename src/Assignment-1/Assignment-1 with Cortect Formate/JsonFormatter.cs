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
           
            
             
            Type type = item.GetType();
           

            if (type == null)
            {
                return null;
            }

            Json += "{ \n ";

            PropertyInfo[] ptypes=type.GetProperties();
             
            for(int i=0;i<ptypes.Length;i++)
            {
                if(ptypes[i].PropertyType.IsPrimitive)
                {
                    Json += $"\"{ptypes[i].Name}\" :";
                    object? value=ptypes[i].GetValue(item);
                    Json += $" {value}";
                    if(i!=ptypes.Length-1)
                    {
                        Json += ", \n";
                    }
                    

                }
                else if(ptypes[i].PropertyType==typeof(string))
                {
                    Json += $" \"{ptypes[i].Name}\" : ";
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
                else if(ptypes[i].PropertyType.IsArray) 
                {
                    if (ptypes[i].PropertyType == typeof(int[]))
                    {
                        int[] arr = (int[])ptypes[i].GetValue(item);

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
                    if (ptypes[i].PropertyType == typeof(string[]))
                    {
                        string[] arr = (string[])ptypes[i].GetValue(item);
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
                    if (ptypes[i].PropertyType == typeof(char[]))
                    {
                        char[] arr = (char[])ptypes[i].GetValue(item);
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
                    if (ptypes[i].PropertyType == typeof(DateTime[]))
                    {
                        DateTime[] arr = (DateTime[])ptypes[i].GetValue(item);
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
                else if(ptypes[i].PropertyType == typeof(DateTime))
                {
                    Json += $" \"{ptypes[i].Name} \" : ";
                   object? value= ptypes[i].GetValue(item);

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
                else if (ptypes[i].PropertyType.IsClass && !ptypes[i].PropertyType.IsGenericType)
                {
                    Json += $"\"{ptypes[i].Name}\" : ";
                    Convert(ptypes[i].GetValue(item));
                    
                    if (i != ptypes.Length - 1)
                    {
                        Json += ", \n";
                    }
                    else
                    {
                        Json += "\n";
                    }

                }
                if(ptypes[i].PropertyType.IsGenericType)
                {
                    Json += $"\"{ptypes[i].Name}\" : [ \n";
                    object obj = ptypes[i].GetValue(item);
                    foreach(var items in obj as IList)
                    {
                        Convert(items);
                        
                    }
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
            Json += "}";

            return Json;

        }
    }
}
