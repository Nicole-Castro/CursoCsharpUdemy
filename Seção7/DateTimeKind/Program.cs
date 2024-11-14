using System;

namespace Date // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime d1 = new DateTime(2000,4,14,13,25,54,DateTimeKind.Local);
            // DateTime d2 = new DateTime(2000,4,14,13,25,54,DateTimeKind.Utc);
            // DateTime d3 = new DateTime(2000,4,14,13,25,54);

            // System.Console.WriteLine(d1);
            // System.Console.WriteLine(d1.Kind);
            // System.Console.WriteLine(d1.ToLocalTime());
            // System.Console.WriteLine(d1.ToUniversalTime());
            // System.Console.WriteLine(d2);
            // System.Console.WriteLine(d2.Kind);
            // System.Console.WriteLine(d2.ToUniversalTime());
            // System.Console.WriteLine(d3);
            // System.Console.WriteLine(d3.Kind);

            DateTime d1 = DateTime.Parse("2000-12-06 13:05:55");
            DateTime d2 = DateTime.Parse("2000-12-06T13:05:55Z");
            System.Console.WriteLine(d1);
            System.Console.WriteLine(d2);
        }
    }
}