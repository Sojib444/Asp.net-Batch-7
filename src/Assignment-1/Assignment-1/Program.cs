using Assignment_1;
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

//Same method signeture which you want.

string json=JsonFormatter.Convert_(take_a_type);

Console.WriteLine();
Console.WriteLine("-----------------------------Convert Object JSON-----------------------\n");

Console.WriteLine(json);
