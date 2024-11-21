using System;
using System.Globalization;

namespace Exercicio2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario a,b;
            a = new Funcionario();
            b = new Funcionario();

            System.Console.WriteLine("Digite os dados do Primeiro funcionario: ");
            System.Console.Write("Nome: ");
            a.nome = Console.ReadLine() ?? "vazio";
            System.Console.Write("Salario: ");
            a.salario = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            System.Console.WriteLine("Digite os dados do Segundo funcionario: ");
            System.Console.Write("Nome: ");
            b.nome = Console.ReadLine() ?? "vazio";
            System.Console.Write("Salario: ");
            b.salario = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            double salarioMedio = (a.salario + b.salario)/2.0;
            System.Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}