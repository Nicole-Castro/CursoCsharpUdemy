﻿using System.Globalization;
using FuncionariosEx.Entities;

namespace FuncionariosEx;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>();
        Console.WriteLine("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i<=n;i++){
            System.Console.WriteLine($"Emplyee #{i} data: ");
            System.Console.Write("Outsourced? (y/n): ");
            char ch = char.Parse(Console.ReadLine());
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            System.Console.Write("Value Per Hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (ch == 'y' || ch == 'Y'){
                System.Console.Write("Additional Charge: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new OutsourcedEmployee(name, hours, valuePerHour,additionalCharge));
            }else{
                list.Add(new Employee(name, hours,valuePerHour));
            }
        }

        Console.WriteLine("");
        Console.WriteLine("PAYMENTS: ");
        foreach (Employee emp in list){
            Console.WriteLine(emp.Name + " - $"+ emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
