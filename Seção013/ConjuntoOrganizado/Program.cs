namespace ConjuntoOrganizado;

class Program
{
    static void Main(string[] args)
    {
        PrintService<string> printService= new PrintService<string>();
        System.Console.WriteLine("How many values? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n;i++){
            System.Console.WriteLine("Type a value: ");
            string x= Console.ReadLine();
            printService.AddValue(x);
        }

        printService.Print();
        System.Console.WriteLine("Fisrt: " + printService.First());
    }
}
