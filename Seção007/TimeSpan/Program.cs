using System;
using System.Globalization;

namespace CondicionalTernaria // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TimeSpan t1 = new TimeSpan();
            // TimeSpan t2 = new TimeSpan(900000000L);
            // TimeSpan t3 = new TimeSpan(2,11,21);
            // TimeSpan t4 = new TimeSpan(1,2,11,21);
            // TimeSpan t5 = new TimeSpan(1,2,11,21,255);
            // System.Console.WriteLine(t1);
            // System.Console.WriteLine(t2);
            // System.Console.WriteLine(t3);
            // System.Console.WriteLine(t4);
            // System.Console.WriteLine(t5);
            // TimeSpan t1 = TimeSpan.FromDays(1.4);
            // TimeSpan t2 = TimeSpan.FromHours(1.5);
            // TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            // TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            // TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            // TimeSpan t6 = new TimeSpan(900000000L);

            // System.Console.WriteLine(t1);
            // System.Console.WriteLine(t2);
            // System.Console.WriteLine(t3);
            // System.Console.WriteLine(t4);
            // System.Console.WriteLine(t5);
            // System.Console.WriteLine(t6);
            // TimeSpan t1 = TimeSpan.MaxValue;
            // TimeSpan t2 = TimeSpan.MinValue;

            // System.Console.WriteLine(t1);
            // System.Console.WriteLine(t2);
            // TimeSpan t = new TimeSpan(2, 3, 5,7,11);
            // System.Console.WriteLine(t);
            // System.Console.WriteLine("Days: " + t.Days);
            // System.Console.WriteLine("Hours: " + t.Hours);
            // System.Console.WriteLine("Minutes: " + t.Minutes);
            // System.Console.WriteLine("Millisenconds: " + t.Milliseconds);
            // System.Console.WriteLine("Seconds: " + t.Seconds);
            // System.Console.WriteLine("Ticks: " + t.Ticks);
            // System.Console.WriteLine("Total Days: " + t.TotalDays);
            // System.Console.WriteLine("Total Hours: " + t.TotalHours);
            // System.Console.WriteLine("Total Minutes: " + t.TotalMinutes);
            // System.Console.WriteLine("Total Seconds: " + t.TotalSeconds);
            // System.Console.WriteLine("Total Milliseconds: " + t.TotalMilliseconds);
            TimeSpan t1 = new TimeSpan(1,30,10);
            TimeSpan t2 = new TimeSpan(0,10,5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t2.Subtract(t1);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            System.Console.WriteLine(sum);
            System.Console.WriteLine(dif);
            System.Console.WriteLine(mult);
            System.Console.WriteLine(div);
        }
    }
}