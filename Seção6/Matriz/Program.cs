using System;
using System.Runtime.ConstrainedExecution;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double[,] mat = new double[2,3];
            // Console.WriteLine(mat.Length);
            // Console.WriteLine(mat.Rank);
            // Console.WriteLine(mat.GetLength(0));
            // Console.WriteLine(mat.GetLength(1));

            System.Console.Write("Qual a ordem da matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            System.Console.WriteLine("Insira os números na matriz: ");
            for(int i = 0; i < n; i++){
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++){
                    mat[i,j] = int.Parse(values[j]);
                }
                
            }
            

            System.Console.WriteLine("Main diagonal: ");
            for(int i = 0;i < n; i++){
                Console.Write(mat[i,i] + " ");
            }

System.Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

        }
    }
}