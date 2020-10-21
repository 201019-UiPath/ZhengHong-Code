using System;
using System.Text.RegularExpressions;


namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("give a valid email address");
            }

            while (!Regex.IsMatch(Console.ReadLine(), "\\w+@\\w+\\.\\w+"));


            Console.Write("a valid email address found");


        }
    }
}
