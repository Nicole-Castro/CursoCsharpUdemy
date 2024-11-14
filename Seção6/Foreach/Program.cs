using System;

namespace Foreach // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex","Bob"};
            foreach (string obj in vect){
                Console.WriteLine(obj);
            }

        }
    }
}