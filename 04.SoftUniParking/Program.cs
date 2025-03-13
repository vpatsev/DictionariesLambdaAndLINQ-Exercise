int n = int.Parse(Console.ReadLine());

Dictionary<string, string> parking = new();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    string command = input[0];   
    string username = input[1]; 

    if (command == "register")
    {
     string licenseNum = input[2];

        if (parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
        }
        if(!parking.ContainsKey(username)) {

            parking.Add(username, licenseNum);
            Console.WriteLine($"{username} registered {licenseNum} successfully");

        }
    }
    else if(command == "unregister")
    {
        if (!parking.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            parking.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }

        
    }
    
}
foreach (var kvp in parking)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}

