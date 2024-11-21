namespace SortedSetTest;

class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> s1 = new SortedSet<int>(){0,6,4,5,3,7};
        SortedSet<int> s2 = new SortedSet<int>() {4,7,1,2,3};
        PrintCollection(s1);

        SortedSet<int> s3 = new SortedSet<int>(s1);

        //union
        s3.UnionWith(s2);
        PrintCollection(s3);

        //intersection
        SortedSet<int> s4 = new SortedSet<int>(s1);
        s4.IntersectWith(s2);
        PrintCollection(s4);

        //difference
        SortedSet<int> s5 = new SortedSet<int>(s1);
        s5.ExceptWith(s2);
        PrintCollection(s5);

    }

    static void PrintCollection<T>(IEnumerable<T> collection){
        foreach(T item in collection){
            Console.Write(item + " ");
        }
        System.Console.WriteLine();
    }
}
