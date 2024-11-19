namespace StreamWriterTest;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"/home/nicole/Documentos/C#/file1.txt";
        string targetPath = @"/home/nicole/Documentos/C#/file2.txt";
        try
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
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
