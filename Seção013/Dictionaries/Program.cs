namespace Dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> cookies = new Dictionary<string, string>();

        cookies["user"] = "Maria";
        cookies["email"] = "maria@gmail.com";
        cookies["phone"] = "9994924249";
        cookies["phone"] = "3141441341";

        System.Console.WriteLine(cookies["phone"]);
        System.Console.WriteLine(cookies["email"]);

        cookies.Remove("email");

        if (cookies.ContainsKey("email")){
            System.Console.WriteLine(cookies["email"]);
        }else{
            System.Console.WriteLine("There is no email key");
        }

        System.Console.WriteLine("Size: " + cookies.Count);

        System.Console.WriteLine("All cookies: ");
        foreach(KeyValuePair<string, string> item in cookies){
            System.Console.WriteLine(item.Key + " = " + item.Value);
        }


    }
}
