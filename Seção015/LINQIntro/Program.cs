namespace LINQIntro;

class Program
{
    static void Main(string[] args)
    {
        //specufy the data source
        int[] numbers = new int[] { 1, 2, 3, 4, 5};

        //define the query expression
        IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

        //Execute the query
        foreach (int x in result){
            Console.WriteLine(x);
        }
    }
}
