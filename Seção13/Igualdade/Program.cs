using Igualdade.Entities;

namespace Igualdade;

class Program
{
    static void Main(string[] args)
    {
        HashSet<Product> a= new HashSet<Product>();

        a.Add(new Product("TV", 1287.99));
        a.Add(new Product("Computer", 1231.99));

        HashSet<Point> b= new HashSet<Point>();

        b.Add(new Point(2, 5));
        b.Add(new Point(12, 7));

        Product prod = new Product("Computer", 1231.99);

        System.Console.WriteLine(a.Contains(prod));

        Point p = new Point(2, 5);

        System.Console.WriteLine(b.Contains(p));
    }
}
