namespace VoteCount;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    int votes = int.Parse(line[1]);

                    if (dict.ContainsKey(name)){
                        dict[name] += votes;
                    }else{
                        dict[name] = votes;
                    }
                }
                foreach (KeyValuePair<string, int> items in dict)
                {
                    Console.WriteLine(items.Key + ": " + items.Value);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
