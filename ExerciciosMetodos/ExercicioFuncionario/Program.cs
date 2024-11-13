using System;
using System.Globalization;

namespace ExercicioFuncionario // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f;
            f = new Funcionario();

            Console.WriteLine("Entre os dados do funcionario: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine() ?? "vazio";
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine() ?? "0.0",CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine() ?? "0.0",CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + f);
            Console.WriteLine("");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine()?? "0.0",CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: "+ f);
        }
    }
}