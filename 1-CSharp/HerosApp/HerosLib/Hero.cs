using System;

namespace HerosLib
{
    public class Hero
    {
   
        // public int id;
        // public string name;

        public int id {get;set;}
        public string name{get;set;}
        public string[] superPowers = new string[10];

        public int[][] ja = new int[2][];
        public Hero()
        {
            this.id = 5;
            this.name = "name";
            this.ja[0]=new int [2];
            this.ja[0][1]=33;

        }

        public Hero(int id, string name)
        {
            
        }
    }


}
