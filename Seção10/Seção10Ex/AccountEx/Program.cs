using System.Globalization;
using AccountEx.Entities;
using AccountEx.Entities.Exceptions;

namespace AccountEx;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter account data");
            System.Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Holder: ");
            string holder = Console.ReadLine();
            System.Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Withdraw limit: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, balance, withdraw);

            System.Console.WriteLine();
            System.Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(amount);
            System.Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (DomainException e)
        {
            Console.WriteLine("Withdraw Error: " + e.Message);
        }
    }
}
