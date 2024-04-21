using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

CSharpObjectToJson();
JsonToCSharpObject();

#region C# Object to JSON

static void CSharpObjectToJson()
{
    Product product = new Product();
    product.Name = "Apple";
    product.Expiry = new DateTime(2008, 12, 28);
    product.Sizes = new string[] { "Small" };

    string json = JsonConvert.SerializeObject(product);
    Console.WriteLine(json);
}

#endregion

#region JSON to C# Object

static void JsonToCSharpObject()
{
    var jsonData = """
    {
      "Name": "Apple",
      "Expiry": "2008-12-28T00:00:00",
      "Sizes": [
        "Small",
        "Medium",
        "Large"
      ]
    }
""";
    var productDto = JsonConvert.DeserializeObject<Product>(jsonData);
    if (productDto is null) return;

    Console.WriteLine(productDto.Name);
    Console.WriteLine(productDto.Expiry);
    Console.WriteLine(string.Join(", ", productDto.Sizes));
}

#endregion

Console.ReadLine();

// {
//   "Name": "Apple",
//   "Expiry": "2008-12-28T00:00:00",
//   "Sizes": [
//     "Small"
//   ]
// }


public class Product
{
    public string Name { get; set; }
    public DateTime Expiry { get; set; }
    public string[] Sizes { get; set; }
}
