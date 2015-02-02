using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Assignment02
{
    //SuperHero class is a subclass	of the Hero superclass from	Assignment1
    class SuperHero : Hero
    {
        string superPower1, superPower2, superPower3; 
        //PRIVATE PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string[] superPowers;

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public SuperHero(string name,int strength,int speed,int health) :
            base(name, strength, speed, health)
        {
            this.generateRandomPowers();
        }

        // Private METHODS +++++++++++++++++++++++++++++++++++++++++++
        // Randomly generates three random superpowers
        private void generateRandomPowers()
        {
            string[] superPowers = { "Super	Speed", "Super	Strength", "Body Armour", "Flight", 
                                     "Fire Generation", "Weather Control"};
            
            string[] randomPowers = new string[3];
            Random rnd = new Random();
            for(int i = 0 ; i < randomPowers.Length ; i++)
            {
                  randomPowers[i] = superPowers[rnd.Next(superPowers.Length)];
                  //test randomPowers[i] value
                  //Console.WriteLine("{0}", randomPowers[i]);
                  superPowers[i] = randomPowers[i];
                  //test superPowers[i] value
                  //Console.WriteLine("{0}", superPowers[i]);
            }
            superPower1 = superPowers[0];
            superPower2 = superPowers[1];
            superPower3 = superPowers[2];
        }

        //PUBLIC METHODS
        public void showPowers()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("The hero's super powers are:");
            Console.WriteLine("1) {0}", superPower1);
            Console.WriteLine("2) {0}", superPower2);
            Console.WriteLine("3) {0}", superPower3);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
        }
    }
}
