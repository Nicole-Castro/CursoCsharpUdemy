using System;
using System.Globalization;

namespace CondicionalTernaria // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco *0.1 : preco * 0.05;

            System.Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}