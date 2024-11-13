using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine() ?? "0.0");
            double area = (Math.PI)*Math.Pow(raio,2);
            Console.WriteLine("A = " + area);
        }
    }
}