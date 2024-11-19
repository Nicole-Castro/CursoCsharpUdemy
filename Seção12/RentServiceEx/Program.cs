using System.Globalization;
using RentServiceEx.Entities;
using RentServiceEx.Services;

namespace RentServiceEx;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data: ");
        System.Console.Write("Car Model: ");
        string carModel = Console.ReadLine(); 
        System.Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        System.Console.Write("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        System.Console.Write("Enter Price per Hour: ");
        double hour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        System.Console.Write("Enter Price per Day: ");
        double day = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        CarRental carRental = new CarRental(start,finish, new Vehicle(carModel));

        RentalService rentalService= new RentalService(hour,day, new BrasilTaxService());

        rentalService.ProcessInvoice(carRental);

        System.Console.WriteLine("INVOICE: ");
        System.Console.WriteLine(carRental.Invoice);

    }
}
