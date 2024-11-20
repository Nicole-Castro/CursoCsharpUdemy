using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceTest.Devices;

namespace DeviceTest
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            System.Console.WriteLine("Printer processing " + document);
        }

        public void Print(string document){
            System.Console.WriteLine("Printer print: " + document);
        }
    }
}