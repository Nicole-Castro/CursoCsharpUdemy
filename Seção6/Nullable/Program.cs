using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nullable<Double> x = null;
            double? x = null;
            double? y = 10.0;

            //GetValueOrDefault pega o valor de x ou o valor padrão caso for nulo
            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(y.GetValueOrDefault());

            // retorna verdadeiro ou falso caso tenha ou não valor
            System.Console.WriteLine(x.HasValue);
            System.Console.WriteLine(y.HasValue);

            if(x.HasValue){
                System.Console.WriteLine(x.Value);
            }else{
                System.Console.WriteLine("X is null");
            }
            if(y.HasValue){
                System.Console.WriteLine(y.Value);
            }else{
                System.Console.WriteLine("Y is null");
            }
            // OPERADOR DE COALESCÊNCIA NULA
            double? a = null;
            double? b = 10;

            double c = x ?? 5;
            double d = y ?? 5;
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
        }
    }
}