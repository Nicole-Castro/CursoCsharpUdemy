using System;
using System.Globalization;

namespace Esfera2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));
        }

        
    }
}