using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;


namespace Assignment_1
{
    public class JsonFormatter
    {


        public static string Convert_(object item)
        {

            Type? take_a_type =(Type) item;



            string Json = "";
            //Working for Json
            Json += "{";


            void Json_Convertor(Type T)
            {

                PropertyInfo[] proerties = T.GetProperties();
                Console.WriteLine();
                Console.WriteLine($" In '{T.Name}' There are '{proerties.Length}' properties." +
                    $" Please set the value of property one by one\n");
                Console.WriteLine("Property Name" + "\t" + "Property-Type");
                Console.WriteLine("-------------" + "\t" + "-------------");
                foreach (var item in proerties)
                {
                    Console.Write("    " + item.Name + "\t" + "     " + item.PropertyType.Name + "\n");
                }
                Console.WriteLine();

                //foreach (PropertyInfo p in proerties)
                for (int i = 0; i < proerties.Length; i++)
                {
                    if (proerties[i].PropertyType.IsPrimitive)
                    {
                        Console.Write($"The '{proerties[i].Name}' of the {T.Name} and the Property Type {proerties[i].PropertyType} = ");
                        string? value = Console.ReadLine();
                        object? instance = Activator.CreateInstance(T);
                        proerties[i].SetValue(instance, Convert.ChangeType(value, proerties[i].PropertyType));
                        Json += $"\"{proerties[i].Name}\" : \"{value}\"";
                        if (i != proerties.Length - 1)
                        {
                            Json += ",\n";
                        }



                    }
                    else if (proerties[i].PropertyType == typeof(string))
                    {
                        Console.Write($"The '{proerties[i].Name}' of the {T.Name} = ");
                        string? value = Console.ReadLine();
                        object? instance = Activator.CreateInstance(T);
                        proerties[i].SetValue(instance, Convert.ChangeType(value, proerties[i].PropertyType));
                        Json += $"\"{proerties[i].Name}\" : \"{value}\"";
                        if (i != proerties.Length - 1)
                        {
                            Json += ",\n";
                        }
                    }
                    else if (proerties[i].PropertyType.IsGenericType)
                    {
                        Type[] generics_paramerters = proerties[i].PropertyType.GetGenericArguments();
                        for (int j = 0; j < generics_paramerters.Length; j++)
                        {
                            Json += $" \"{proerties[i].Name}\" : [";
                            Console.WriteLine($"Now You have to work with '{proerties[i].Name}' " +
                                $"and return type of this properties 'List<{generics_paramerters[j].Name}>' \n");
                            Console.WriteLine($"Plese press 'Enter' and Ready to  Move '{generics_paramerters[j].Name}'" +
                            $" class");
                            Console.ReadKey();
                            Console.Write($"\nHow Many {generics_paramerters[j].Name} for " +
                                $"{proerties[i].Name}  Do You want to Add? = ");
                            int w = Convert.ToInt32(Console.ReadLine());
                            for (int k = 1; k <= w; k++)
                            {
                                Json += "{";
                                Console.WriteLine($"\n--------For {generics_paramerters[j].Name}-> {k}--------");
                                Json_Convertor(generics_paramerters[j]);
                                if (k != w)
                                {
                                    Json += "},";
                                }
                                else
                                {
                                    Json += "}";
                                }
                            }

                            if (i != proerties.Length - 1)
                            {
                                Json += "],";
                            }
                            else
                            {
                                Json += "]";
                            }
                        }
                    }
                    else if (proerties[i].PropertyType == typeof(DateTime))
                    {
                        Console.Write($"The '{proerties[i].Name}' of the {T.Name}" +
                            $" in this Formate('month-date-year') = ");
                        object? value = Console.ReadLine();
                        object? instance = Activator.CreateInstance(T);
                        proerties[i].SetValue(instance, Convert.ChangeType(value, proerties[i].PropertyType));
                        //Json
                        Json += $"\"{proerties[i].Name}\" : \"{proerties[i].GetValue(instance)}\"";
                        if (i != proerties.Length - 1)
                        {
                            Json += ",\n";
                        }
                        //Console.WriteLine(p.GetValue(instance));
                        //Console.WriteLine();

                    }
                    else if (proerties[i].PropertyType.IsClass)
                    {
                        Console.WriteLine($"\nNow You have to work with '{proerties[i].Name}'of  " +
                            $"and return type of " + $"this properties '{proerties[i].PropertyType.Name}'Class ");
                        Console.WriteLine($"Plese press 'Enter' and Ready to " +
                            $" Move '{proerties[i].PropertyType.Name}'  class");
                        Console.ReadKey();
                        Json += $"\"{proerties[i].Name}\" : " + "{";
                        Json_Convertor(proerties[i].PropertyType);
                        if (i != proerties.Length - 1)
                        {
                            Json += "},\n";
                        }
                        else
                            Json += "}\n";
                    }


                }


            }

            Json_Convertor(take_a_type);
            Json += "}";
            

            return Json;
        }
    }
}
