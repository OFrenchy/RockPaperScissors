using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScizzorsLizardSpock
{
    class Player
    {
        // class - … Is A …
        // member variables - … Has A …
        public bool isHuman;
        public string name;
        public int score;
        private int currentSelection;
        
        public Player() //string name, bool isHuman)
        {
            this.score = 0;
            this.name = UserInterface.promptForStringInput("Enter this player's name:");
            //this.isHuman = UserInterface.promptForCharInput("Is this player human?  Enter y or n:" )  == Convert.ToChar("y");
            this.isHuman = (UserInterface.promptForYesNoInput("Is this player human?  Enter y or n:") 
                == Convert.ToChar("y"));

            //promptForYesNoInput
        }
        // member methods - … Can Do …
        public virtual int MakeSelection(int rangeZeroBased)
        {
            // prompt for selection
            string message = name + "'s turn: Please make a selection, enter 1 for Rock, 2 for Paper, " +
                "3 for Scissors, 4 for Lizard, or 5 for Spock: ";
            currentSelection = Convert.ToInt32(UserInterface.pickWholeNumberOneThrough(5, message, !isHuman) - 1);
            // if this player is not human, write its selection to the window
            if (!isHuman)
            {
                Console.WriteLine(currentSelection + 1);
            }
            return currentSelection;
        }
        
        public int GetCurrentSelection()
        {
            return currentSelection;
        }
        public int incrementScore()
        {
            score++;
            return score;
        }
        public void newGame()
        {
            score = 0;
        }
    }
}
