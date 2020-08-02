using System;
using Utility;

namespace DataStructsAnAlgPract
{
    class Program
    {
        static void Main(string[] args)
        {
            string x, y;

            Console.WriteLine("Greetings...");
            x = Console.ReadLine();
            Console.WriteLine("Password : ");
            y = Console.ReadLine();

            if (Authorizor.Login(x,y))
            {
                Console.WriteLine("\n\n Welcome Back Yash");
                Console.WriteLine(x.GetHashCode());
            }else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
