using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame
{
    class Dice
    {

        /* 
         * Name of last person: Luke Poff
         * Last updated: 9/22/2021
         * Method: DiceRoller()
         * Description: diceRoll is randomized for numbers 1-6. The switch case is
         * some kind  of visualization.
         */
        public int DiceRoller()
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 7);
            switch(diceRoll)
            {
                case 1:
                    Console.WriteLine(" -----------\n|          |\n|" +
                     "          |\n|   one    |\n|          |\n|" + 
                     "          |\n ----------");
                    break;
                case 2:
                    Console.WriteLine(" -----------\n|          |\n|" +
                    "          |\n|   two    |\n|          |\n|" +
                    "          |\n ----------");
                    break;
                case 3:
                    Console.WriteLine(" -----------\n|          |\n|" +
                    "          |\n|   three  |\n|          |\n|" +
                    "          |\n ----------");
                    break;
                case 4:
                    Console.WriteLine(" -----------\n|          |\n|" +
                    "          |\n|   four   |\n|          |\n|" +
                    "          |\n ----------");
                    break;
                case 5:
                    Console.WriteLine(" -----------\n|          |\n|" +
                    "          |\n|   five   |\n|          |\n|" +
                    "          |\n ----------");
                    break;
                case 6:
                    Console.WriteLine(" -----------\n|          |\n|" +
                    "          |\n|   six    |\n|          |\n|" +
                    "          |\n ----------");
                    break;


            }
            return diceRoll;
        }

        /* 
         * Name of last person: Luke Poff
         * Last updated: 9/22/2021
         * Method: DiceTheDice()
         * Prompts the user if they would like to roll the dice. Handles inccorect input
         * with the while loop. 
         */
        public static void RollTheDice()
        {
            string answer = "yes";
            string rollquestion = "yes";

            while (rollquestion.ToLower() == answer)
            {
                Console.WriteLine("Would you like to roll the dice?");
                rollquestion = Console.ReadLine();

                while (rollquestion.ToLower() != answer || rollquestion.ToLower() != "no")
                {
                    if (rollquestion.ToLower() == "yes")
                    {
                        Dice d = new Dice();
                        Console.WriteLine(d.DiceRoller());


                        Console.WriteLine("Would you like to roll the dice?");
                        rollquestion = Console.ReadLine();

                    }
                    else if (rollquestion.ToLower() == "no")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Enter yes or no. Do you want to roll again?");
                        rollquestion = Console.ReadLine();
                    }

                }
                
             

            }
        }

   }
}



