namespace DirectoriesTest;

class Program
{
    static void Main(string[] args)
    {
        string path = @"/home/nicole/Documentos/C#/myFolder";
        try
        {
            IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            System.Console.WriteLine("FOLDERS");
            foreach (string folderItem in folder){
                System.Console.WriteLine(folderItem);
            }
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            System.Console.WriteLine("FILES");
            foreach (string filesItems in files){
                System.Console.WriteLine(filesItems);
            }

            Directory.CreateDirectory(path + @"/newfolder");
        }
        catch (IOException e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}
