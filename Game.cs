using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScizzorsLizardSpock
{
    class Game
    {

        // class - … Is A …
        // member variables - … Has A …

        // players array of type Player
        private Player[] players;
        // rules array of type Rule
        private Rule[] rules;
        // round array of type Round
        private Round[] round;
        //private UserInterface userInterface;
        

        // constructor … Spawns A …
        public Game()
        {
            
        }

        // member methods - … Can Do …
        public void playRockPaperScissorsLizardSpock(int numberOfPlayers)
        {
            // Create the players list
            List<Player> players = new List<Player>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player());
            }
            
            // TODO - ccreate/add rules & methods
            Rules rules = new Rules();
            
            string roundResults = "";
            //string roundSelections = "";
            do
            {
                Player roundWinner = new Player();
                Round thisRound = new Round();
                roundResults = thisRound.playRound(players);
                //pronounce the winner of this round
                roundResults = roundResults + "\n" + rules.DetermineRoundWinner(players);
                UserInterface.displayMessage(roundResults, true);
            }
            while (! rules.gameOver(players));
            // pronounce the winner

        }

    }
}
