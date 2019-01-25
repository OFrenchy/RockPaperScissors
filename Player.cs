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
            this.isHuman = UserInterface.promptForCharInput("Is this player human?  Enter y or n:" )  == Convert.ToChar("y");
        }
        // member methods - … Can Do …
        public virtual int MakeSelection(int rangeZeroBased)
        {
            // prompt for selection
            // TODO - validate selection later
            //return Convert.ToInt64(UserInterface.PromptForCharInput("Make a selection, enter\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock" )) ;
            //return Convert.ToInt32( UserInterface.promptForStringInput("blah blah blah"));
            string message = "Make a selection, enter\n1 for Rock\n2 for Paper\n3 for Scissors\n4 for Lizard\n5 for Spock";
            return Convert.ToInt32(UserInterface.pickWholeNumberOneThrough(5, message, !isHuman)) - 1;
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
    }
}
