using System;
using Pensionato;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] aluguelVet = new Aluguel[10];

            for (int i = 0; i < n; i++){
                System.Console.WriteLine("Aluguel #" + (i+1) + ":");
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                System.Console.Write("");
                aluguelVet[quarto] = new Aluguel{Nome = nome, Email = email, Quarto = quarto};
            }
            System.Console.WriteLine("Quartos ocupados");
            for (int i = 0; i < 10; i++){
                if (aluguelVet[i] != null){
                    System.Console.WriteLine(i + ": "+ aluguelVet[i].Nome + ", " + aluguelVet[i].Email);
                }
            }
        }
    }
}