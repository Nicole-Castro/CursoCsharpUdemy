using System;
using System.Globalization;
using ExercicioProduto;

namespace E // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine() ?? "vazio";
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine() ?? "0");

            System.Console.WriteLine("Dados do produto: " + p);
        }
    }
}