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
        private UserInterface UserInterface;






        // constructor … Spawns A …
        public Game()
        {
            UserInterface userInterface = new UserInterface();

            
        }

        // member methods - … Can Do …
        public void playRockPaperScissorsLizardSpock(int numberOfPlayers)
        {
            // DONE - //TODO - change into an array or list of Player-s, or Player[]
            //Player player1 = new Player();
            //Player player2 = new Player();

            // Create the players list
            List<Player> players = new List<Player>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add( new Player());
            }

            

            Rules rules = new Rules();


            //do round, then
            //    increment score, 
            //reset winnerThiusRounbd

            // string roundWinner = "";
            do
            {
                Round thisRound = new Round(player1, player2);
                // roundWinner = thisRound.playRound();
                thisRound.playRound();
                //pronounce the winner of this rounds
                rules.
            }
            while (player1.score < 2 && player2.score < 2);
            // pronounce the winner

        }

    }
}
