
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

    foreach (PropertyInfo p in proerties)
    {
        if (p.PropertyType.IsPrimitive)
        {
            Console.Write($"The Property-Name is '{p.Name}' and return types " +
                $" '{p.PropertyType}' plese set a '{p.PropertyType.Name}' value = ");
            object? value = Console.ReadLine();
            object instance = Activator.CreateInstance(T);
            p.SetValue(instance, Convert.ChangeType(value, p.PropertyType));
            //Json
            Json += $" \"{p.Name}\" : {p.GetValue(instance)}";
            Json += ", \n";
            //Console.WriteLine(p.GetValue(instatance));
            //Console.WriteLine();
        }

        else if (p.PropertyType == typeof(string))
        {

            Console.Write($"The '{p.Name}' of the {T.Name} = ");
            object? value = Console.ReadLine();
            object? instance = Activator.CreateInstance(T);
            p.SetValue(instance, Convert.ChangeType(value, p.PropertyType));
            //Json
            Json += $" \"{p.Name}\" : \"{p.GetValue(instance)}\"";
            Json += ", \n";
            //Console.WriteLine(p.GetValue(instance));
            //Console.WriteLine();

        }
        else if (p.PropertyType.IsGenericType)
        {
            Type[] generics_paramerters = p.PropertyType.GetGenericArguments();
            foreach (Type type in generics_paramerters)
            {
                //Json
                Json += $" \"{p.Name}\" : [";
                Console.WriteLine($"Now You have to work with '{p.Name}' and return type of " +
                $"this properties 'List<{type.Name}>' \n");
                Console.WriteLine($"Plese press 'Enter' and Ready to  Move '{type.Name}'" +
                                $" class");
                Console.ReadKey();

                //Json
                Json += "{";
                Json_Convertor(type);
                Json += "},";


            }
            Json += "],\n";


        }
        else if (p.PropertyType == typeof(DateTime))
        {
            Console.Write($"The '{p.Name}' of the {T.Name} in this Formate('month-date-year') = ");
            object? value = Console.ReadLine();
            object? instance = Activator.CreateInstance(T);
            p.SetValue(instance, Convert.ChangeType(value, p.PropertyType));
            //Json
            Json += $" \"{p.Name}\": \"{p.GetValue(instance)}\"";
            Json += ", \n";
            //Console.WriteLine(p.GetValue(instance));
            //Console.WriteLine();

        }
        else if (p.PropertyType.IsClass)
        {
            Console.WriteLine($"Now You have to work with '{p.Name}' and return type of " +
                $"this properties '{p.PropertyType.Name}' \n");
            Console.WriteLine($"Plese press 'Enter' and Ready to  Move '{p.PropertyType.Name}'" +
                            $" class");
            Console.ReadKey();
            Json += $"\"{p.Name}\" : [";
            Json += "{";
            Json_Convertor(p.PropertyType);
            Json += "} \n],";

        }
        
      


    }


}

Json_Convertor(take_a_type);
Json += "}";

Console.WriteLine(Json);







