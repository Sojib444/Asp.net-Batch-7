
using Assignment;
using System.Collections;
using System.Reflection;

Assembly assembly = Assembly.GetExecutingAssembly();
Type[] types = assembly.GetTypes();
Console.WriteLine("All those class that are present in the Assembly \n");
foreach (Type t in types)
{
    Console.WriteLine(t.Name);
}
Console.WriteLine();
Console.WriteLine("Please type this class Name which you work with");
string Name = Console.ReadLine();

Type? take_a_type = assembly.GetType($"Assignment.{Name}");



String Json = "";
//Working for Json
Json += "{";


void Json_Convertor(Type T)
{

    PropertyInfo[] proerties = T.GetProperties();
    Console.WriteLine();
    Console.WriteLine($" In '{T.Name}' There are '{proerties.Length}' properties. Please set the" +
                                   $" value of property one by one\n");
    Console.WriteLine("Property Name" + "\t" + "Property-Type");
    Console.WriteLine("-------------" + "\t" + "-------------");
    foreach (var item in proerties)
    {
        Console.Write("    " + item.Name + "\t" + "     " + item.PropertyType.Name + "\n");
    }
    Console.WriteLine();

    //foreach (PropertyInfo p in proerties)
    for(int i=0;i<proerties.Length;i++)
    {
        if (proerties[i].PropertyType.IsPrimitive)
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
                Console.WriteLine($"Now You have to work with '{proerties[i].Name}' and return type of " +
                                $"this properties 'List<{generics_paramerters[j].Name}>' \n");
                Console.WriteLine($"Plese press 'Enter' and Ready to  Move '{generics_paramerters[j].Name}'" +
                $" class");
                Console.ReadKey();
                Console.Write($"\nHow Many {generics_paramerters[j].Name} for {generics_paramerters[j].Name}  Do You want to Add? = ");
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
            Console.Write($"The '{proerties[i].Name}' of the {T.Name} in this Formate('month-date-year') = ");
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
        else if(proerties[i].PropertyType.IsClass)
          {
            Console.WriteLine($"\nNow You have to work with '{proerties[i].Name}'of  " +
                $"and return type of " +$"this properties '{proerties[i].PropertyType.Name}'Class ");
            Console.WriteLine($"Plese press 'Enter' and Ready to  Move '{proerties[i].PropertyType.Name}'" +
                            $" class");
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

Console.WriteLine(Json);







