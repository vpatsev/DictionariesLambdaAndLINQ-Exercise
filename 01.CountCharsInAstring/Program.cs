string input = Console.ReadLine();

Dictionary<char,int> chars = new ();

for (int i = 0; i < input.Length; i++)
{
    char currentChar = input[i];

    if (currentChar == ' ')
    {
        continue;
    }

    if (!chars.ContainsKey(currentChar))
    {
        chars.Add(currentChar, 1);
    }
    else
    {
        chars[currentChar]++;
    }
     
}     
foreach(KeyValuePair<char,int> kvp  in chars)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}