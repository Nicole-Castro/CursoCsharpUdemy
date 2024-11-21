using HotelEx.Entities;

namespace HotelEx;

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

            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                System.Console.WriteLine("Reservation dates for update must be future dates");
            }
            else if (checkOut <= checkIn)
            {
                System.Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                reservation.UpdateDates(checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);

            }
        }
    }
}
