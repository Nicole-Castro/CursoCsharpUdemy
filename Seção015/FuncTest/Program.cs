﻿using FuncTest.Entities;

namespace FuncTest;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        //List<string> result = list.Select(NameUpper).ToList();

        // Func<Product, string> func = NameUpper;
        Func<Product, string> func = p => p.Name.ToUpper();
        // List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
        List<string> result = list.Select(func).ToList();

        foreach (string item in result){
            Console.WriteLine(item);
        }
    }

    static string NameUpper(Product p){
        return p.Name.ToUpper();
    }
}
