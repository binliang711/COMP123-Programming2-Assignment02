/*
 * studentName:Bin Liang | studentNumber:300788322
 * Date last Modified:Feb 3rd,2015
 * Program description:COMP123_Assignment02,Implement the SuperHero Class.
 * Revision	History:
 * 1.This is 1st edition,copy part of codes from Assignment01,debug successfully!
 * 2.Improve codes, so do not contain any duplicate superpower!
 * 3.Improve comments and output effects.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero aSuperHero = new SuperHero("superman",50,60,70);
            aSuperHero.showPowers();
            aSuperHero.fight();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
