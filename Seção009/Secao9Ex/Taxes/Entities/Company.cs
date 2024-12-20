using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxes.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(){

        }
        public Company(string name, double anualIncome, int numberOfEmployees): base(name, anualIncome){
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            if (NumberOfEmployees <= 10){
                return AnualIncome * 0.16;
            }else{
                return AnualIncome * 0.14;
            }
        }

    }
}