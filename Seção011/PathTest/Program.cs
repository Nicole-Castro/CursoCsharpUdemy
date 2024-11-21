namespace PathTest;

class Program
{
    static void Main(string[] args)
    {
                string path = @"/home/nicole/Documentos/C#/myFolder/file1.txt";
                System.Console.WriteLine(Path.DirectorySeparatorChar);
                System.Console.WriteLine(Path.PathSeparator);
                System.Console.WriteLine(Path.GetDirectoryName(path));
                System.Console.WriteLine(Path.GetFileName(path));
                System.Console.WriteLine(Path.GetFileNameWithoutExtension(path));
                System.Console.WriteLine(Path.GetExtension(path));
                System.Console.WriteLine(Path.GetFullPath(path));
                System.Console.WriteLine(Path.GetTempPath());

    }
}
