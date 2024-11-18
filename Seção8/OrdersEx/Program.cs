using System.Globalization;
using OrdersEx.Entities;
using OrdersEx.Entities.Enums;

namespace OrdersEx;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter client data: ");
        System.Console.Write("Name: ");
        string name = Console.ReadLine();
        System.Console.Write("Email: ");
        string email = Console.ReadLine();
        System.Console.Write("Birth Date (DD/MM/YYYY): ");
        DateTime birth = DateTime.Parse(Console.ReadLine());
        Client client = new Client(name, email, birth);

        System.Console.WriteLine("Enter order Data: ");
        System.Console.Write("Status: ");
        if (!Enum.TryParse(Console.ReadLine(), true, out OrderStatus os))
        {
            Console.WriteLine("Invalid order status. Please use valid values.");
            return;
        }

        System.Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());
        Order order = new Order(DateTime.Now, os, client);
        for (int i = 1; i <= n; i++)
        {
            System.Console.WriteLine($"Enter #{i} item data:");
            System.Console.Write("Product name: ");
            string nameProduct = Console.ReadLine();

            System.Console.Write("Product price: ");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(nameProduct, productPrice);
            OrderItem orderItem = new OrderItem(quantity, product.Price);
            orderItem.AddProduct(product);
            order.AddItem(orderItem);
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Order Summary: ");
        System.Console.Write("Order moment: " + order.ToString());
    }
}
