


using HerosLib;
using System;
using System.Text.RegularExpressions;

namespace HerosUI.Menus
{
    public class MainMenu : IMenu
    {

        public void Start()
        {
            do
            {
                Console.WriteLine("give a number 1 through 9");
                // options

            }
            while (!Regex.IsMatch(Console.ReadLine(), "\\d+"));



            Hero obj = GetHeroDetails();

            Console.WriteLine(obj.name);
            Console.WriteLine("Hero created");
            // Console.WriteLine("give a valid email address");


            do
            {


                Console.WriteLine("give a valid email address");

            }

            while (!Regex.IsMatch(Console.ReadLine(), "\\w+@\\w+\\.\\w+"));



        }

        public Hero GetHeroDetails()
        {
            Hero hero = new Hero();
            Console.WriteLine("Enter Hero Name");
            hero.name = Console.ReadLine();



            return hero;




        }

    }
}