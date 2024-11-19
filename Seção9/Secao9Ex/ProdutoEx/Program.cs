using System.Globalization;
using ProdutoEx.Entities;

namespace ProdutoEx;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products= new List<Product>();
        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <=n;i++){
            System.Console.WriteLine($"Product #{i} data:");
            System.Console.Write("Common, used or imported (c/u/i)? ");
            char type = char.Parse(Console.ReadLine());
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
            if(type == 'c'){
                products.Add(new Product(name,price));
            }else if(type == 'i'){
                System.Console.Write("Custom Fee: ");
                double custom = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                products.Add(new ImportedProduct(name,price,custom));

            }else{
                System.Console.Write("Manufactured date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                products.Add(new UsedProduct(name,price,date));
            }

        }

        Console.Write("");
        System.Console.WriteLine("PRICE TAGS");
        foreach (Product product in products){
            Console.WriteLine(product);
        }
    }
}
