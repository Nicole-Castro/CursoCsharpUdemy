using System;
using System.Globalization;
using ExercicioAluno;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.WriteLine("Entre os dados do aluno");
            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine() ?? "vazio";
            Console.Write("Nota 1: ");
            a.Nota1 = double.Parse(Console.ReadLine() ?? "0.0",CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            a.Nota2 = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            a.Nota3 = double.Parse(Console.ReadLine() ?? "0.0",CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));
            if(a.Aprovado()){
                Console.WriteLine("APROVADO");
            }else{
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + a.Reprovado().ToString("F2",CultureInfo.InvariantCulture) + " PONTOS");
            }


        }
    }
}