using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScizzorsLizardSpock
{
    class Rules
    {
        // Rock (0)     crushes     Scissors (2)
        // Rock (0)     crushes     Lizard (3)
        // Paper (1)    covers      Rock (0)
        // Paper (1)    disproves   Spock (4)
        // Scissors (2) cuts        Paper (1)
        // Scissors (2) decapitates Lizard (3)
        // Lizard (3)   poisons     Spock (4)
        // Lizard (3)   eats        Paper (1)
        // Spock (4)    smashes     Scissors (2)
        // Spock (4)    vaporizes   Rock (0)

        // build list to hold rules
        List<List<int>> rules = new List<List<int>>();
        // build each individual rule
        List<int> rule0RockBeats = new List<int>() {2, 3};
        List<int> rule1PaperBeats = new List<int>() {0, 4};
        List<int> rule2ScissorsBeats = new List<int>() {1, 3};
        List<int> rule3LizardBeats = new List<int>() {1, 4};
        List<int> rule4SpockBeats = new List<int>() {0, 2};

        // TODO - change to calculate based on number of players
        // change to one more than half of the players
        int gameWinnerRoundCount = 2;  

        public Rules()
        {
            rules.Add(rule0RockBeats);
            rules.Add(rule1PaperBeats);
            rules.Add(rule2ScissorsBeats);
            rules.Add(rule3LizardBeats);
            rules.Add(rule4SpockBeats);
        }
        
        public string DetermineRoundWinner(List <Player> players)
        {
            // get answer to who won this round & increment that player's score
            // first set playerToBeat to the first element in the list
            // loop through array while i+1 < list.length(), 
            //      comparing playerToBeat to el(i+), determining who won & setting playerToBeat, 
            
            int i = 0;
            int playerToBeat = 0;
            bool roundEndsInTie = false;
            do
            {
                // if the 2nd player's choice is in the 1st player's choice Beats list, 
                //      the 1st player wins, else the 2nd player wins
                //List<int> rule4SpockBeats = new List<int>() { 0, 2 };
                //rules[players[i].GetCurrentSelection].FindIndex( , players[i + 1].GetCurrentSelection);
                //firstUsersSelectionBeatsList.IndexOf(players[i + 1].GetCurrentSelection());
                
                // Check for all players with the same selection
                if (players[playerToBeat].GetCurrentSelection() == players[i + 1].GetCurrentSelection())
                {
                    roundEndsInTie = true;
                }
                else
                {
                    List<int> playerToBeatSelectionBeatsList = new List<int>();
                    playerToBeatSelectionBeatsList = rules[players[playerToBeat].GetCurrentSelection()];
                    if (playerToBeatSelectionBeatsList.IndexOf(players[i + 1].GetCurrentSelection()) >= 0)
                    {
                        playerToBeat = i;   // first user beats second
                        roundEndsInTie = false;
                    }
                    else
                    {
                        playerToBeat = i + 1;// second user beats first
                        roundEndsInTie = false;
                    }
                }
                i++;
            }
            while ((i + 1) < players.Count());

            if (roundEndsInTie)
            {
                return "Round ends in a tie.";
            }
            else
            {
                // playerToBeat is the winner of this round; increment his score
                players[playerToBeat].incrementScore();
                return players[playerToBeat].name + " wins this round.";
            }
        }
        public bool gameOver(List<Player> players)
        {
            // loop through the players, if one has a score of gameWinnerRoundCount , 
            // display the scores of each player & congratulate the winner, & return true
            foreach (Player thisPlayer in players)
            {
                if (thisPlayer.score > gameWinnerRoundCount)
                {
                    // congratulate winner
                    UserInterface.displayMessage(thisPlayer.name + " wins!", false);
                    return true;
                }
            }
            return false;
        }
    }
}
