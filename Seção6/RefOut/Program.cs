using System;
using RefOut;

namespace RefOut // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            int res;
            Calculator.TripleOut(a,out res);
            Console.WriteLine(res);

        }
    }
}