namespace TryCatchExceptions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 / n2);
        }catch(DivideByZeroException e){
            Console.WriteLine("Error! " + e.Message);
        }catch(FormatException e){
            Console.WriteLine("Format Error! " + e.Message);
        }


    }
}
