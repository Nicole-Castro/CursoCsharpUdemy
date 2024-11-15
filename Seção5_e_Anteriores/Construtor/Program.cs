﻿using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "vazio";
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            // Console.Write("Quantidade no estoque: ");
            // int quantidade = int.Parse(Console.ReadLine() ?? "0");

            // Produto p = new Produto(nome, preco, quantidade);
            Produto p = new Produto(nome, preco);
            Produto p2 = new Produto{ 
                Nome = "Tv",
                Preco = 500.00,
                Quantidade = 2
            };
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine() ?? "0");
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine() ?? "0");
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            
        }
    }
}