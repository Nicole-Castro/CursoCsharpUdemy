using System;
using System.Globalization;

namespace CondicionalTernaria // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ  abc  ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3,5);

            string s6 = original.Replace("a","x");
            string s7 = original.Replace("abc","xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            System.Console.WriteLine("Original: "+original);
            System.Console.WriteLine("ToUpper: "+s1);
            System.Console.WriteLine("ToLower: "+s2 + "-");
            System.Console.WriteLine("Trim: "+s3+"-");
            System.Console.WriteLine("IndexOf('bc'): " +n1);
            System.Console.WriteLine("LastIndexOf('bc'): " +n2);
            System.Console.WriteLine("Substring(3): " +s4);
            System.Console.WriteLine("Substring(3,5): " +s5);
            System.Console.WriteLine("Replace(a,x): " +s6);
            System.Console.WriteLine("Replace(abc,xy): " +s7);
            System.Console.WriteLine("Is Null Or Empty: " +b1);
            System.Console.WriteLine("Is Null Or White Space: " +b2);
        }
    }
}