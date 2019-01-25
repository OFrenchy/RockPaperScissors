using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScizzorsLizardSpock
{
    public static class UserInterface
    {
        public static string[] selectionNames = {"Rock", "Paper", "Scissors", "Lizard", "Spock"};
        //// helper function to pass into promptFor to validate yes/no answers
        //// CHANGED to allow user to hit escape or click cancel, which results in a null
        //public string yesNo(string input)
        //{
        //    string test = input.ToLower();
        //    test = test(0);
        //    return test == "y" || test == "n"  // || input == null;
        //}

        public static int pickWholeNumberOneThrough(int upperBound, string message, bool isRandom = false)
        {
            // pick a whole number from 1 to upperBound;  if you want a random number, don't prompt
            if (!isRandom)
            {
                string input = promptForStringInput(message);
                // TODO - validate input, 
                // if string
                // if beyond upperBound

                return int.Parse(input);  // TODO tryParse
            }
            else
            {
                //generate random number from 1 to upperBound 
                //Random()
                Random randomGenerator = new Random();
                return(randomGenerator.Next(upperBound - 1) + 1);
            }
        }

        public static string promptForStringInput(string message)
        {
            Console.WriteLine(message);
            // TODO - validate input
            return Console.ReadLine();
        }
        public static char promptForCharInput(string message)
        {
            Console.WriteLine(message);
            // TODO - validate input
            //string test = Console.ReadLine();
            return Convert.ToChar(Console.ReadLine().Substring(0, 1).ToLower());    //.Substring(0, 1);
        }
        public static void displayMessage(string message, bool pauseForReturnEnter)
        {
            Console.WriteLine(message);
            if (pauseForReturnEnter)
            {
                Console.Read();
            }
        }
        public static string UserInterface()
        {

        }



    }
}
