namespace PortalCursos;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> courseA = new HashSet<int>();
        HashSet<int> courseB = new HashSet<int>();
        HashSet<int> courseC = new HashSet<int>();

        System.Console.Write("How many students for course A?");
        int n1 = int.Parse(Console.ReadLine());
        for (int i = 0; i <n1; i++){
            courseA.Add(int.Parse(Console.ReadLine()));
        }

        System.Console.Write("How many students for course B?");
        int n2 = int.Parse(Console.ReadLine());
        for (int i = 0; i <n2; i++){
            courseB.Add(int.Parse(Console.ReadLine()));
        }

        System.Console.Write("How many students for course C?");
        int n3 = int.Parse(Console.ReadLine());
        for (int i = 0; i <n3; i++){
            courseC.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> all = new HashSet<int>(courseA);
        all.UnionWith(courseB);
        all.UnionWith(courseC);
        Console.WriteLine("Total Students: " + all.Count);
    }
}
