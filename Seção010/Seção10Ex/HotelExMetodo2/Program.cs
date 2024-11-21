using HotelExMetodo2.Entities;

namespace HotelExMetodo2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Room Number: ");
        int number = int.Parse(Console.ReadLine());
        System.Console.Write("Check-in date (dd/MM/yyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        System.Console.Write("Check-out date (dd/MM/yyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());
        if (checkOut <= checkIn)
        {
            System.Console.WriteLine("Error in reservation: Check-out date must be after Check-in date.");


        }
        else
        {
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            System.Console.WriteLine("Reservation: " + reservation);

            System.Console.WriteLine();
            System.Console.WriteLine("Enter date to update the reservation:");
            System.Console.Write("Check-in date (dd/MM/yyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Check-out date (dd/MM/yyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            string error = reservation.UpdateDates(checkIn, checkOut);
            if (error != null)
            {
                System.Console.WriteLine("Error in reservation: " + error);
            }
            else
            {
                System.Console.WriteLine("Reservation: " + reservation);

            }
        }
    }
}
