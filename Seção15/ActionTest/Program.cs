using ActionTest.Entities;

namespace ActionTest;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));
        //Action<Product> action = UpdatePrice;
        //Action<Product> action = p=> { p.Price += p.Price * 0.1;};
        list.ForEach( p=> { p.Price += p.Price * 0.1;});

        foreach (Product product in list){
            System.Console.WriteLine(product);
        }
    
    }

    static void UpdatePrice(Product p){
        p.Price += p.Price * 0.1;
    }
}
