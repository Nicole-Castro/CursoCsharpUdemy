﻿using Acessos.Entities;

namespace Acessos;

class Program
{
    static void Main(string[] args)
    {
        HashSet<LogRecord> logRecords = new HashSet<LogRecord>();

        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);

                    logRecords.Add(new LogRecord { UserName = name, Instant = instant });
                }
                System.Console.WriteLine("Total User: " + logRecords.Count);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
