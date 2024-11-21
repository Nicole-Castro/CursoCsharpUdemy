using System;
using Course;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2,3,4,6,8,5);
            System.Console.WriteLine(s1);
        }
    }
}