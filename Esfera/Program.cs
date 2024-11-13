using System;
using System.Globalization;

namespace Esfera // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio");
            double raio = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            double volume = Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2",CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double raio){
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio){
            return 4.0 / 3.0 *Pi*raio*raio*raio;
        }
    }
}