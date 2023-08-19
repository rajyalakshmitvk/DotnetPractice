// See https://aka.ms/new-console-template for more information
namespace CaseConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string in lower case");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter a string in upper case");
            string s2= Console.ReadLine();
            Console.WriteLine("upper case of string {0} is {1}", s1, s1.ToUpper());
            Console.WriteLine("Lower case of string {0} is {1}", s2, s2.ToLower());
        }
    }

}

