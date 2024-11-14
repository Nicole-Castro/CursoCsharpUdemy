using System;
using System.Globalization;
using System.Security.Cryptography;
using Banco;

namespace Banco // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1;
            Console.Write("Entre o numero da conta: ");
            int NumConta = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Entre o titular da conta: ");
            string Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            string DepInicial = Console.ReadLine();
            if (DepInicial == "s" || DepInicial == "S")
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                double ValorDepInicial = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
                c1 = new ContaBancaria(NumConta, Nome, ValorDepInicial);
            }
            else
            {
                c1 = new ContaBancaria(NumConta, Nome);
            }
            System.Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c1);
            System.Console.WriteLine("");

            System.Console.Write("Entre um valor para deposito: ");
            double dep = double.Parse(Console.ReadLine());
            c1.Deposito(dep);
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(c1);

            System.Console.WriteLine("");

            System.Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            c1.Saque(saque);

            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(c1);


        }
    }
}