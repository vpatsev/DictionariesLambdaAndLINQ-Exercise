string input = Console.ReadLine();

Dictionary<string, double[]> products = new();

while(input != "buy")
{

    string[] productToken = input.Split(" ");
    string productName = productToken[0];   
    double productPrice = double.Parse(productToken[1]);
    double productQuantity = double.Parse(productToken[2]);

    if (!products.ContainsKey(productName))
    {
        products.Add(productName,new double[2]);
    }
    products[productName][0] = productPrice;
    products[productName][1] += productQuantity;

    input = Console.ReadLine(); 
}

foreach(var kvp in products)
{

    double productPrice = kvp.Value[0] * kvp.Value[1];

    Console.WriteLine($"{kvp.Key} -> {productPrice:F2}");
}