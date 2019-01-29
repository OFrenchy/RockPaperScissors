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

        // member methods - … Can Do …

        public string playRound(List<Player> players)   // change this to receive a list or array of Player objects
        {
            // Announce the start of a new round
            UserInterface.displayMessage("\nNew round!", false);
            string userPicks = "";
            foreach (Player thisPlayer in players)
            {
                userPicks = userPicks + thisPlayer.name + " picked " +
                    UserInterface.selectionNames[thisPlayer.MakeSelection(UserInterface.selectionNames.Length)] + ". ";
                //? thisPlayer.name;// + "; " + thisPlayer.GetCurrentSelection().ToString ;
            }
            // Announce who picked what
            UserInterface.displayMessage(userPicks, false);
            return userPicks;
        }
    }
}
