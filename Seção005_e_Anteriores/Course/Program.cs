using System;
using System.Globalization;
namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Triangulo x,y; // variaveis x e y são do tipo triangulo
            x = new Triangulo(); // nova instacia de triangulo na variavel x
            y = new Triangulo(); // nova instacia de triangulo na variavel y
    

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            
            
            double areaX = x.Area();

        
            double areaY = y.Area();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Maior area: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
        }


    }
}