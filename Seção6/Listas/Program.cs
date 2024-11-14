using System;

namespace Listas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string>{"Maria","Alex"};
            list.Add("Joao");
            list.Add("Marcelo");
            list.Add("Ana");
            list.Add("Antonio");

            list.Insert(2, "Laura");

    
            foreach (string item in list)
            {
                 System.Console.WriteLine(item);
                
            }

            Console.WriteLine(list.Count);
            string s1 = list.Find(x => x[0] == 'A');

            System.Console.WriteLine("First A " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo A " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            System.Console.WriteLine("First pos A: " +pos1 );

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            System.Console.WriteLine("Last pos A: " +pos2 );

            List<string> list3 = list.FindAll(x => x.Length ==7 );

            foreach (string item in list3){
                System.Console.WriteLine(item);
            }
            list.Remove("Ana");

            foreach (string item in list)
            {
                 System.Console.WriteLine(item);
                
            }

            list.RemoveAll(x => x[0] == 'M');

            foreach (string item in list)
            {
                 System.Console.WriteLine(item);
                
            }

            list.RemoveAt(2);

            foreach (string item in list)
            {
                 System.Console.WriteLine(item);
                
            }

            list.RemoveRange(0,1);
            foreach (string item in list)
            {
                 System.Console.WriteLine(item);
                
            }
        }
    }
}