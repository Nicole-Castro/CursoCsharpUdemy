using System.Globalization;
using Taxes.Entities;

namespace Taxes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());
        List<TaxPayer> list = new List<TaxPayer>();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax payer #{i} data: ");
            System.Console.Write("Individual or company (i/c)? ");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'i' || ch == 'I')
            {
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Health Exependitures: ");
                double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Individual(name,anualIncome,health));
            }
            else if (ch == 'c' || ch == 'C')
            {
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Number of Employees: ");
                int numberEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Company(name,anualIncome,numberEmployees));
            }
        }


        System.Console.WriteLine();
        System.Console.WriteLine("TAXES PAID: ");
        foreach(TaxPayer tax in list){
            System.Console.WriteLine(tax.Name + ": $ " + tax.Tax().ToString("F2",CultureInfo.InvariantCulture));
        }
        double sum = 0;

        foreach(TaxPayer tax in list){
            sum = sum + tax.Tax();
        }
        System.Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2",CultureInfo.InvariantCulture));

    }
}
