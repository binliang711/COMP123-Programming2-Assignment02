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
        string randomSuperPower1, randomSuperPower2, randomSuperPower3; 
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
            //A way to declare and initialize an array
            string[] superPowers = { "Super Speed", "Super Strength", "Body Armour", "Flight", 
                                     "Fire Generation", "Weather Control"};
            //declare a new array
            string[] randomPowers = new string[3];
            
            Random rnd = new Random();
            int randomPower;

            //Assign cells from an array to another 
            int index = 0;
            while (index < 3)
            {
                randomPower = generateRandomPower(rnd);
                if (superPowers[randomPower] != "unbelievable")
                {
                    randomPowers[index] = superPowers[randomPower];
                    superPowers[randomPower] = "unbelievable";
                    index++;
                }
            }

            //Alternate Looping Structure
            /*
            for(int i = 0 ; i < randomPowers.Length ; i++)
            {
               randomPower = generateRandomPower(rnd);

               if (superPowers[randomPower] != "unbelievable")
               {
                  randomPowers[i] = superPowers[randomPower] ;
                  superPowers[randomPower] = "unbelievable";
               }   
            }
            */
            randomSuperPower1 = randomPowers[0];
            randomSuperPower2 = randomPowers[1];
            randomSuperPower3 = randomPowers[2];
        }

        //PRIVATE METHODS,generate random number for super power.
        private static int generateRandomPower(Random rnd)
        {
            int randomPower;
            randomPower = rnd.Next(6);
            Console.WriteLine("Random super power number is {0}", randomPower);// Debugging line
            return randomPower;
        }
        

        //PUBLIC METHODS,output random super power.
        public void showPowers()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("The hero's super powers are:");
            Console.WriteLine("1) {0}", randomSuperPower1);
            Console.WriteLine("2) {0}", randomSuperPower2);
            Console.WriteLine("3) {0}", randomSuperPower3);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
        }
    }
}
