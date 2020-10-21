using System;
using System.Collections.Generic;
namespace HerosLib
{
    public class Hero
    {

        // public int id;
        // public string name;

        public int id { get; set; }
        public string name { get; set; }
        public static Stack<string> superPowers = new Stack<string>();
        public static Dictionary<string, string> hideOuts = new Dictionary<string, string>();

        public int[][] ja = new int[2][];
        public Hero()
        {
            this.id = 5;
            this.name = "name";
            this.ja[0] = new int[2];
            this.ja[0][1] = 33;




        }
        //ctor short cut for create constructor in vs code

        public Hero(int id, string name)
        {
        }

        public static Stack<String> GetSuperPowers()
        {
            return superPowers;
        }


        public static void RemoveSuperPower()
        {

            superPowers.Pop();

        }


        public static void AddSuperPowers()
        {

            superPowers.Push("Strength");
            superPowers.Push("Fly");
            superPowers.Push("Visibility");
            superPowers.Push("See through");

        }

        public static void AddHideOuts()
        {


            hideOuts.Add("key1", "value1");
        }
    }


}
