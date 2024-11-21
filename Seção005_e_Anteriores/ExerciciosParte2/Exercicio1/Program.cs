using System;

namespace Exercicio1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa a,b;
            a = new Pessoa();
            b = new Pessoa();
            Console.WriteLine("Digite os dados da primeira pessoa: ");
            a.nome = Console.ReadLine() ?? "vazio";
            a.idade = int.Parse(Console.ReadLine() ?? "0");
        
            Console.WriteLine("Digite os dados da segunda pessoa: ");
            b.nome = Console.ReadLine() ?? "vazio";
            b.idade = int.Parse(Console.ReadLine() ?? "0");

            if (a.idade > b.idade){
                Console.WriteLine("A pessoa mais velha é " + a.nome);
            }
            else if(b.idade > a.idade){
                Console.WriteLine("A pessoa mais velha é " + b.nome);
            }
            else{
                Console.WriteLine("As idade são iguais");
            }
        }
    }
}