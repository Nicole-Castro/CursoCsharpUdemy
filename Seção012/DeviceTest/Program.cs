using DeviceTest.Devices;

namespace DeviceTest;

class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer(){
            SerialNumber = 1080
        };
        p.ProcessDoc("My letter");
        p.Print("My Letter");

        Scanner s = new Scanner() {
            SerialNumber = 500
        };
        s.ProcessDoc("My emaik");
        System.Console.WriteLine(s.Scan());

        ComboDevice c = new ComboDevice() {
            SerialNumber = 5516
        };
        c.ProcessDoc("My dwohef");
        c.Print("fwrgv");
        System.Console.WriteLine(c.Scan());
    }
}
