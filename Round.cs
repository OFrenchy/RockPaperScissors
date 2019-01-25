using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScizzorsLizardSpock
{
    class Round
    {

        // class - … Is A …
        // member variables - … Has A …

        // constructor … Spawns A …
        public Round()
        {

        }

            
        public string playRound(Player player1, Player player2)   // change this to receive a list or array of Player objects
        {
            int player1Choice;
            int player2Choice;

            // in case there is a tie, use a while
            do
            {
                player1Choice = player1.MakeSelection(UserInterface.selectionNames.Length);
                player2Choice = player2.MakeSelection(UserInterface.selectionNames.Length);
                string message = player1.name + " selected " + UserInterface.selectionNames[player1Choice] + ", "
                    + player2.name + " selected " + UserInterface.selectionNames[player2Choice] + ". ";
                UserInterface.promptForStringInput(message);
                message = rules.DetermineRoundWinner(player1.GetCurrentSelection(), player2.GetCurrentSelection());
                UserInterface.promptForStringInput(message);
            }
            while (player1Choice == player2Choice);


            return "what?";
        }
        // member methods - … Can Do …


    }
}
