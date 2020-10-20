using System;
using HerosLib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hero obj = new Hero();
            Console.WriteLine($"{obj.id}{"\n"}{obj.name}");
            Console.WriteLine(obj.id);
            Console.WriteLine(obj.ja);
            Console.WriteLine(obj.ja[0][0]);

            Console.WriteLine(obj.ja[0][1]);

            // Console.WriteLine(obj.ja[1][0]);
            int [,] td = new int [2,4];
            Console.WriteLine(td);



        }
    }
}
