using System.Reflection.PortableExecutable;

string input = Console.ReadLine();

Dictionary<string, int> resources = new();

while(input != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!resources.ContainsKey(input))
    {
        resources.Add(input, 0);
    }

    resources[input] += quantity;


    input = Console.ReadLine(); 
}

foreach(var kvp  in resources)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}