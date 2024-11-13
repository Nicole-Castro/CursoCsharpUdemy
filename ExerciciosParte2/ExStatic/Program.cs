using System;
using System.Globalization;
using ExStatic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do Dólar: ");
            double cot = double.Parse(Console.ReadLine()??"0.0", CultureInfo.InvariantCulture);
            Console.Write("Digite quantos dólares deseja comprar: ");
            double quant = double.Parse(Console.ReadLine()??"0.0", CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + Cotacao.Valor(cot,quant).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}