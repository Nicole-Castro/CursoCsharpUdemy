using System.Globalization;
using FuncionarioEx.Entities;

namespace FuncionarioEx;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();
        List<Employee> list = new List<Employee>();
        using (StreamReader sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                string[] data = sr.ReadLine().Split(',');
                string name = data[0];
                string email = data[1];
                double salary = double.Parse(data[2], CultureInfo.InvariantCulture);

                list.Add(new Employee(name, email, salary));
            }
        }

        System.Console.Write("Enter Salary: ");
        double salarySearch = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var s1 = list.Where(p => p.Salary > 2000.0).OrderBy(p => p.Name).Select(p => p.Email);
        System.Console.WriteLine("Email of people whose salary is more than 2000.00:");

        foreach (var emp in s1)
        {
            Console.WriteLine(emp);
        }
        var s2 = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
        Console.WriteLine("Sum of salary of people whose name starts with 'M': " + s2.ToString("F2",CultureInfo.InvariantCulture));
    }
}
