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
                UserInterface.displayMessage("Player " + (i+1).ToString() + ":" , false);
                players.Add(new Player());
            }
            Rules rules = new Rules();
            do
            {
                // Clear the screen
                Console.Clear();
                UserInterface.displayMessage(rules.getListOfWhatBeatsWhatAndHow(), false);
                string roundResults = "";
                do
                {
                    Round thisRound = new Round();
                    roundResults = thisRound.playRound(players);
                    //pronounce the winner of this round
                    roundResults = rules.DetermineRoundWinner(players);
                    UserInterface.displayMessage(roundResults, false);
                }
                // pronounce the winner
                while (!rules.gameOver(players));
                resetPlayersScores(players);
            }
            while (UserInterface.promptForYesNoInput("Do you want to play again? y or n").ToString() == "y") ;
        }
        public void resetPlayersScores(List<Player> players)
        {
            foreach (Player thisPlayer in players)
            {
                thisPlayer.score = 0;
            }
        }

    }
}
