using System;
using System.Globalization;

namespace CondicionalTernaria // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime d1 = DateTime.Now;
            // DateTime d2 = new DateTime(2018,11,25);
            // DateTime d3 = new DateTime(2018,11,25,20,45,3);
            // DateTime d4 = new DateTime(2018,11,25,20,45,3,500);
            // DateTime d5 = DateTime.Today;
            // DateTime d6 = DateTime.UtcNow;
            // System.Console.WriteLine(d1);
            // System.Console.WriteLine(d1.Ticks);
            // System.Console.WriteLine(d2);
            // System.Console.WriteLine(d3);
            // System.Console.WriteLine(d4);
            // System.Console.WriteLine(d5);
            // System.Console.WriteLine(d6);
            // DateTime d1 = DateTime.Parse("2000-08-15");
            // DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            // DateTime d3 = DateTime.Parse("15/08/2000");
            // DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
            // System.Console.WriteLine(d1);
            // System.Console.WriteLine(d2);
            // System.Console.WriteLine(d3);
            // System.Console.WriteLine(d4);
            // DateTime d1 = DateTime.ParseExact("2000-08-05","yyyy-MM-dd",CultureInfo.InvariantCulture);
            // DateTime d2 = DateTime.ParseExact("25/07/2000 12:05:45","dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);
            // System.Console.WriteLine(d1);
            // System.Console.WriteLine(d2);

            // DateTime d = new DateTime(2001,6,15,13,21,55,245);
            // System.Console.WriteLine(d);
            // System.Console.WriteLine("1)Date: " + d.Date);
            // System.Console.WriteLine("2)Day: " + d.Day);
            // System.Console.WriteLine("3)Day of week: " + d.DayOfWeek);
            // System.Console.WriteLine("4)Day of year: " + d.DayOfYear);
            // System.Console.WriteLine("5)Hour: " + d.Hour);
            // System.Console.WriteLine("6)Kind: " + d.Kind);
            // System.Console.WriteLine("7)Millisenconds: " + d.Millisecond);
            // System.Console.WriteLine("8)Minute: " + d.Minute);
            // System.Console.WriteLine("9)Month: " + d.Month);
            // System.Console.WriteLine("10)Second: " + d.Second);
            // System.Console.WriteLine("11)Ticks: " + d.Ticks);
            // System.Console.WriteLine("12)Time of day: " + d.TimeOfDay);
            // System.Console.WriteLine("13)Year: " + d.Year);

            // DateTime d = new DateTime(2001,6,15,13,21,55,245);
            // string s1 = d.ToLongTimeString();
            // string s2 = d.ToShortDateString();
            // string s3 = d.ToShortTimeString();
            // string s4 = d.ToString("yyyy-MM-dd HH:mm:ss");
            // System.Console.WriteLine(d.ToLongDateString());
            // System.Console.WriteLine(s1);
            // System.Console.WriteLine(s2);
            // System.Console.WriteLine(s3);
            // System.Console.WriteLine(s4);
            DateTime d = new DateTime(2001,6,15,13,21,55,245);
            DateTime d2 = d.AddHours(2);

            System.Console.WriteLine(d);
            System.Console.WriteLine(d2);
        }   
    }
}