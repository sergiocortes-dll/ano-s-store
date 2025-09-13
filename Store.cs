using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace chsarp_ana;
public class Product
{
    public int id;
    public string Name;
    public double Price;
    public int Stock;
}

public class Store
{
    public static List<Product> products = new List<Product>();
    public static void Run()
    {
        products.Add(new Product() { id = 1, Name = "Alfajor", Price = 2500, Stock = 55 });
        products.Add(new Product() { id = 2, Name = "Revolcón", Price = 1500, Stock = 25 });
        products.Add(new Product() { id = 3, Name = "Sandwich", Price = 21000, Stock = 17 });
        products.Add(new Product() { id = 4, Name = "Trident", Price = 700, Stock = 40 });
        products.Add(new Product() { id = 5, Name = "Galletitas", Price = 1000, Stock = 20 });
        
        Buy();
    }
    
    public static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(new string('=', 44));
        Console.WriteLine($"{"ANA'S STORE",27}");
        Console.WriteLine(new string('=', 44));
        Console.ResetColor();

        Console.Write("\x1b[1m");
        Console.WriteLine($"{"#",-2} {"PRODUCTO",-21}{"PRECIO",10}{"CANTIDAD",10}");
        Console.Write("\x1b[0m");
        
        foreach (var product in products)
        {
            Console.WriteLine($"{product.id}. {product.Name,-22}{$"${product.Price}",9:F2}{product.Stock,10}");
        }
        Console.WriteLine(new string('-', 44));
    }

    public static int getProductCount()
    {
        int count = 0;

        foreach (var product in products)
        {
            count += product.Stock;
        }

        return count;
    }
    public static void Buy()
    {
        List<Product> boughtProducts = new List<Product>();
        
        while (true)
        {
            if (getProductCount() < 1)
            {
                Console.WriteLine("No tenemos stock suficiente, vuelva otro día.");
                break;
            }
            
            Console.Clear();
            Menu();
            Console.Write("¿Qué quieres comprar? (por número)\n> ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out _))
            {
                Console.WriteLine("Por favor seleccione un numero válido.");
                continue;
            }

            int productId = Convert.ToInt32(input);

            if (productId < 1 || productId > products.Count)
            {
                Console.WriteLine("Producto no encontrado.");
                Console.ReadLine();
                continue;
            }

            Product product = products.First(x => x.id == productId);

            while (true)
            {
                Console.Write($"¿Cuanto quieres de {product.Name}?\n> ");
                string input2 = Console.ReadLine();
            
                if (!int.TryParse(input2, out _))
                {
                    Console.WriteLine("Por favor seleccione un numero válido.");
                    continue;
                }
                
                int productAmount = Convert.ToInt32(input2);
                
                if (productAmount < 1 || productAmount > product.Stock)
                {
                    Console.WriteLine("Cantidad no disponible.");
                    break;
                }

                product.Stock -= productAmount;
                
                Product boughtProduct = new Product() { id = productId, Name = product.Name, Price = product.Price, Stock = productAmount };
                
                boughtProducts.Add(boughtProduct);
                break;
            }
            
            Console.Write("¿Desea seguir comprando? (s/n)\n> ");
            string userResponse = Console.ReadLine();

            if (!userResponse.ToLower().Contains("s")) break;
        }

        double discount = 0;
        double totalPrice = 0;

        if (boughtProducts.Count < 1)
        {
            Console.WriteLine("No compró nada.");
            return;
        }

        foreach (var product in boughtProducts)
        {
            totalPrice += product.Price * product.Stock;
        }
        
        if (totalPrice > 10000) discount = .10;
        if (totalPrice > 20000) discount = .20;
        
        Console.Clear();
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(new string('=', 44));
        Console.WriteLine($"{"RECIBO",25}");
        Console.WriteLine(new string('=', 44));
        Console.ResetColor();

        Console.Write("\x1b[1m");
        Console.WriteLine($"{"PRODUCTO",-14}{"PRECIO",10}{"CANTIDAD",10}{"SUBTOTAL", 10}");
        Console.Write("\x1b[0m");
        
        foreach (var product in boughtProducts)
        {
            Console.WriteLine($"{product.Name,-14}{$"${product.Price}",10:F2}{product.Stock,10}{$"${product.Stock * product.Price}", 10}");
        }
        Console.WriteLine(new string('-', 44));
        Console.WriteLine($"{"Total:", -34}{$"${totalPrice:F2}", 10}");
        Console.WriteLine($"{"Descuento:", -34}{$"{discount * 100}%", 10}");
        Console.WriteLine($"{"Total a pagar:", -34}{$"${totalPrice - (totalPrice * discount):F2}", 10}");
        Console.WriteLine(new string('-', 44));
        
        Console.WriteLine("\n¡Gracias por tu compra!");
    }
}