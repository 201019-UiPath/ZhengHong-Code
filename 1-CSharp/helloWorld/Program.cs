using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!" + DateTime.Now);

            string firstName, lastName;
            Console.WriteLine("Please enter your name");
            firstName = Console.ReadLine();
            lastName = "premade";
            Console.WriteLine("Welcome " + firstName);
            Console.WriteLine($"welcome {firstName} " + lastName);

        }
    }
}
