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

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(new string('=', 44));
        Console.WriteLine($"{"ANO'S STORE",27}");
        Console.WriteLine(new string('=', 44));
        Console.ResetColor();

        Console.Write("\x1b[1m"); 
        Console.WriteLine($"{"#",2}  {"PRODUCTO",-20}{"PRECIO",10}{"CANTIDAD",10}");
        Console.Write("\x1b[0m"); 

        int count = 1;

        foreach (var product in products)
        {
            Console.WriteLine($"{count++,2}. {product.Name,-20}${product.Price,9:F2}{product.Stock,10}");
        }
        
        Console.ResetColor();
    }
}