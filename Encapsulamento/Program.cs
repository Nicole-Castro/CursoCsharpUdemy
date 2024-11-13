using System;
using System.Globalization;
using Course;
namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500.00, 5);
            Console.WriteLine(p.GetNome());
            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
        }
    }
}