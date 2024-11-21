using System.Globalization;
using Heranca.Entities;

namespace Heranca;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre os dados da Conta");
        Account account = new Account(12,"Alex",0.0);
        BusinessAccount account2 = new BusinessAccount(15,"BBC",0.0,500);
         //UPCASTING
        Account acc1 = account2;
        Account acc2 = new BusinessAccount(1008,"Bob",123,399);
        Account acc3 = new SavingsAccount(1006,"Celia",800,0.05);

        //DOWNCASTING
        BusinessAccount acc4 = (BusinessAccount)acc2;
        acc4.Loan(1000.00);

        //SavingsAccount acc5 = (SavingsAccount)acc3;
        
        if(acc3 is BusinessAccount){
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            BusinessAccount acc5 = acc3 as BusinessAccount;
            acc5.Loan(200);
            Console.WriteLine("Success");
        }else if(acc3 is SavingsAccount){
            SavingsAccount acc5 = (SavingsAccount)acc3;
            acc5.UpdateBalance();
            System.Console.WriteLine("Update");
        }
        System.Console.WriteLine(acc4.ToString());

    }
}
