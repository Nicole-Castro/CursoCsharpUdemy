using System;
using System.Globalization;
using Employees;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++){
                System.Console.WriteLine("Employee: " + (i+1));
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            System.Console.Write("Enter the employee id that will have salary increase: "); 
            int idConsulta = int.Parse(Console.ReadLine());
            Employee emp = employees.Find(x => x.Id == idConsulta);
            if(emp == null){
                System.Console.WriteLine("This id does not exist!");
                System.Console.WriteLine();
            }else{
                System.Console.Write("Enter the percentage: ");
                double per = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(per);
                System.Console.WriteLine();
            }
            
            System.Console.WriteLine("Updated list of employees:");
            foreach (Employee item in employees)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}