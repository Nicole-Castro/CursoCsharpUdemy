using System.Diagnostics.Contracts;
using System.Globalization;
using Income.Entities;
using Income.Entities.Enums;

namespace Income;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter department's name: ");
        string deptName = Console.ReadLine();
        Console.WriteLine("Enter worker data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level(Junior/MidLevel/Senior): ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        System.Console.Write("Base Salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Department department = new Department(deptName);
        Worker worker= new Worker(name,level, baseSalary, department);

        System.Console.Write("How many contracts does this worker have: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++){
            System.Console.WriteLine("Enter #" + i + " contract data:");
            System.Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Value per hour: ");
            double valueHour = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            System.Console.Write("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine());
            HourContract contract = new HourContract(date, valueHour, hours);
            worker.AddContractHour(contract);
        }
        System.Console.WriteLine();
        System.Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string monthYear = Console.ReadLine();
        int month = int.Parse(monthYear.Substring(0, 2));
        int year = int.Parse(monthYear.Substring(3));

        System.Console.WriteLine("Name: "+worker.Name);
        System.Console.WriteLine("Department: "+worker.Department.Name);
        System.Console.WriteLine("Income for " + monthYear +": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

    }
}
