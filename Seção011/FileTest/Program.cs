namespace FileTest;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"/home/nicole/Documentos/C#/file1.txt";
        string targetPath = @"/home/nicole/Documentos/C#/file2.txt";

        try{
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);

            string[] lines = File.ReadAllLines(sourcePath);

            foreach (string line in lines){
                Console.WriteLine(line);
            }

        }catch(IOException e){
            Console.WriteLine("An error ocurred");
            System.Console.WriteLine(e.Message);
        }
    }
}
