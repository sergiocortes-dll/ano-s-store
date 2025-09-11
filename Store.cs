using System.Linq;
namespace chsarp_ana;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}

public class Store
{
    public static void Run()
    {
        List<Product> products = new List<Product>();
        
        products.Add(new Product() { Name = "Alfajor", Price = 2500, Stock = 10 });
        products.Add(new Product() { Name = "Revolcón", Price = 500, Stock = 20 });
        products.Add(new Product() { Name = "Barrilete", Price = 400, Stock = 15 });
        products.Add(new Product() { Name = "Galletica", Price = 500, Stock = 30 });

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{"ANO'S STORE", 23}");
        Console.ResetColor();
        Console.Write("\x1b[1m"); 
        Console.WriteLine($"{"PRODUCTO",-23}  {"PRECIO",0}");
        Console.Write("\x1b[0m"); 
        foreach (var product in products)
        {
            int index = products.FindIndex(p => p.Name == product.Name);
            Console.WriteLine($"{index + 1,1}. {product.Name,-20} ${product.Price,10:F2}");
        }
        
        var getterproduct = products.FirstOrDefault(p => p.Name == "alfajor");
        
        Console.Write(getterproduct.Price);
    }
}