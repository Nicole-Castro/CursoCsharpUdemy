using System;
using System.IO;
using System.Collections.Generic;
using ICompaableTest.Entities;

namespace ICompaableTest;

class Program
{
    static void Main(string[] args)
    {
        string path = @"/home/nicole/Documentos/C#/file2.txt";
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }
                list.Sort();
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}
