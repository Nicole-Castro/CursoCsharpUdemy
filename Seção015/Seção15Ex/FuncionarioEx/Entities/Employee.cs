using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionarioEx.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salary){
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}