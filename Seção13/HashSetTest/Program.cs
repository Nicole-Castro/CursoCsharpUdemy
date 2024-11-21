namespace HashSetTest;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();

        set.Add("Maria");
        set.Add("Joao");
        set.Add("Pedro");


        System.Console.WriteLine(set.Contains("Maria"));

        foreach (string s in set){
            System.Console.WriteLine(s);
        }
    }
}
