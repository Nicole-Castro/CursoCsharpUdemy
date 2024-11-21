using System.Globalization;
using Abstrato.Entities;

namespace Abstrato;

class Program
{
    static void Main(string[] args)
    {
        List<Account> list = new List<Account>();

        list.Add(new SavingsAccount(1001, "Alex",500.0,0.01));
        list.Add(new SavingsAccount(1003, "Maria",5022.0,0.01));
        list.Add(new BusinessAccount(1002, "Matias",52.0,500.0));
        list.Add(new BusinessAccount(1004, "Ana",120.0,500.0));
        double sum = 0.0;
        foreach (Account account in list){
            sum+=account.Balance;
        }

        System.Console.WriteLine("Total Balance: " + sum.ToString("F2",CultureInfo.InvariantCulture));

        foreach (Account account in list){
           account.Withdraw(10.0);
        }

        foreach (Account account in list){
            System.Console.WriteLine("Saldo Atualizado para conta " + account.Number +": " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
