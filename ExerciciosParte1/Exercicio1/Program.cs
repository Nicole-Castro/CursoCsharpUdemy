using System;

namespace Exercicio1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine() ?? "0");
            int b = int.Parse(Console.ReadLine() ?? "0");
            int res = a + b;
            Console.WriteLine("Soma = " + res);
        }
    }
}