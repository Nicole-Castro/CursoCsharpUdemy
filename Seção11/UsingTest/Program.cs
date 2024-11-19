namespace UsingTest;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string path = @"/home/nicole/Documentos/C#/file1.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    System.Console.WriteLine(line);
                }
            }

        }
        catch (IOException e)
        {
            System.Console.WriteLine("Error");
            Console.WriteLine(e.Message);
        }
    }
}
