using System;
using HerosLib;
using HerosUI.Menus;
using System.Collections.Generic;



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
            int[,] td = new int[2, 4];
            Console.WriteLine(td);


            Hero.AddSuperPowers();


            // foreach (var i in obj.GetSuperPower())
            // {

            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("input the superpower you want to remove");

            // string spRemoving = Console.ReadLine();
            // Hero.RemoveSuperPower(spRemoving);
            Console.WriteLine(Hero.GetSuperPowers());
            foreach (var i in Hero.GetSuperPowers())
            {

                Console.WriteLine(i);
            }
            Console.WriteLine(2);


            Hero.AddHideOuts();
            foreach (var i in Hero.hideOuts)
            {

                Console.WriteLine($"{i.Key} {i.Value}");
                Console.WriteLine($"{i}");
            }


            IMenu tempM = new MainMenu();

            tempM.Start();



        }
    }
}
