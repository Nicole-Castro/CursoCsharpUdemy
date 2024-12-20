using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelExMetodo2.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public string UpdateDates(DateTime checkIn, DateTime checkOut){
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be future dates";
            }
            if (checkOut <= checkIn)
            {
                return "Error in reservation: Check-out date must be after check-in date";
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;

        }

        override public string ToString()
        {
            return "Room " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " night(s)";
        }
    }
}