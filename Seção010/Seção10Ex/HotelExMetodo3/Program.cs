using HotelExMetodo3.Entities;
using HotelExMetodo3.Entities.Exceptions;

namespace HotelExMetodo3;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Check-in date (dd/MM/yyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Check-out date (dd/MM/yyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut);
            System.Console.WriteLine("Reservation: " + reservation);

            System.Console.WriteLine();
            System.Console.WriteLine("Enter date to update the reservation:");
            System.Console.Write("Check-in date (dd/MM/yyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Check-out date (dd/MM/yyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);
            System.Console.WriteLine("Reservation: " + reservation);
        }
        catch(DomainException e)
        {
            Console.WriteLine("Reservation Error: " + e.Message);
        }catch(FormatException e){
            Console.WriteLine("Format Error: " + e.Message);
        }catch(Exception e){
            Console.WriteLine("Unexpected Error: " + e.Message);
        }
    }
}
