using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceTest.Devices;

namespace DeviceTest
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            System.Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan(){
            return "Scanner scan result";
        }
    }
}