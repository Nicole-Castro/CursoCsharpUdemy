using HashCodeTest.Entities;

namespace HashCodeTest;

class Program
{
    static void Main(string[] args)
    {
        Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
        Client b = new Client { Name = "Joao", Email = "maria@gmail.com"};

        System.Console.WriteLine(a.Equals(b));
        System.Console.WriteLine(a.GetHashCode() + " " +b.GetHashCode());
    }
}
