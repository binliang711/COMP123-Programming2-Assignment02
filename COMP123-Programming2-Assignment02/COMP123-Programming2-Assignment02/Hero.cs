using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Assignment02
{
    //Hero superclass - blueprint for hero objects 
    class Hero
    {
        // PROTECTED PROPERTIES +++++++++++++++++++++++++++++++++++++++++
        protected string name;
        protected int strength;
        protected int speed;
        protected int health;

        // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name, int strength, int speed, int health)
        {
            // Initialize properties via the constructor
            this.name = name;
            this.strength = strength;
            this.speed = speed;
            this.health = health;
            generateAbilities();//Call the generateAbilities method
        }

        // Private METHODS +++++++++++++++++++++++++++++++++++++++++++
        // causes the hero object to randomly generate the ability numbers 
        private void generateAbilities()
        {
            Random rnd = new Random();
            this.strength = rnd.Next(1, 100);
            Console.WriteLine("The hero's strength score is {0}", this.strength);
            this.speed = rnd.Next(1, 100);
            Console.WriteLine("The hero's speed score is {0}", this.speed);
            this.health = rnd.Next(1, 100);
            Console.WriteLine("The hero's health score is {0}", this.health);
            Console.WriteLine("");
        }

        // Public METHODS +++++++++++++++++++++++++++++++++++++++++++
        // Call the hitAttempt method.If it is true,and it will display damage message
        public void fight()
        {
            if (hitAttempt() == true)
            {
                Console.WriteLine("The damage is: {0}", hitDamage());
                Console.WriteLine("");
            }
        }

        // Private METHODS +++++++++++++++++++++++++++++++++++++++++++
        // a method	that will randomly determine if	it is the Hero hits
        private bool hitAttempt()
        {
            int hit = new Random().Next(1, 100);
            Console.WriteLine("The hit is {0}", hit);
            if (hit <= 20)//if hit <= 20,it should belong to 20% of the time.
            {
                Console.WriteLine("Hit successfully...YEAH!");
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine("Hit unsuccessfully...WOW!");
                Console.WriteLine("");
                return false;
            }
        }

        // Private METHODS +++++++++++++++++++++++++++++++++++++++++++
        // a method	that calculates	the	damage the Hero causes to the target
        private int hitDamage()
        {
            int number = new Random().Next(1, 6);
            Console.WriteLine("The random number is {0}", number);
            int damage = this.strength * number;
            return damage;
        }

        // Public METHODS +++++++++++++++++++++++++++++++++++++++++++
        // a method that will display the Hero’s ability scores
        public void show()
        {
            int abilityScore = this.strength + this.speed + this.health;
            Console.WriteLine("The hero's ability score is {0}", abilityScore);
        }
    }
}
