
using System.Globalization;
using ContractEx.Entities;
using ContractEx.Services;

namespace ContractEx;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data: ");
        System.Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        System.Console.Write("Date (dd/MM/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
        System.Console.Write("Contract Value: ");
        double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Enter number of installments: ");
        int installments = int.Parse(Console.ReadLine());

        Contract contract= new Contract(number, date, value);
        ContractService contractService= new ContractService(new PaypalService());
        contractService.ProcessContract(contract, installments);

        System.Console.WriteLine("Installments: ");
         foreach(Installment installment in contract.Installment){
            Console.WriteLine(installment);
        }

    }
}
