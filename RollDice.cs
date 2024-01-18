//Ethan Nance Section 04 group 11
//program that rolls dice 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMission2
{
    //Create the RollDice class
    class RollDice
    {
        //Create the RollDicemethod that receives HowManyRolls as a parameter
        public static int[] RollDiceMethod(int HowManyRolls)
        {
            //Initialize dice and total
            int die1 = 0;
            int die2 = 0;
            int total = 0;

            //Create random 
            Random random = new Random();

            //Create rollTtoals array
            int[] rollTotals = new int[13];

            //For every time the user said to roll the dice, roll them and store the count of each total in the rollTotals array
            for (int iCount = 0; iCount < HowManyRolls; iCount++)
            {
                //Geenrate random number for each dice, and add to total
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                total = die1 + die2;

                //Keep track of how often each total is rolled
                rollTotals[total - 2]++;
            }

            //This is what the method is returning, this array
            return rollTotals;

        }
    }
}
