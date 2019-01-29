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
        // Lizard (3)   eats        Paper (1)
        // Lizard (3)   poisons     Spock (4)
        // Spock (4)    vaporizes   Rock (0)
        // Spock (4)    smashes     Scissors (2)

        // build list to hold rules;  each rule could be its own class given more time
        List<List<int>> rules = new List<List<int>>();
        // build each individual rule, what beats what list
        List<int> rule0RockBeats = new List<int>() {2, 3};      // rock 0 beats scissors 2 & lizard 3
        List<int> rule1PaperBeats = new List<int>() {0, 4};     // paper 1 beats rock 0 & spock 4
        List<int> rule2ScissorsBeats = new List<int>() {1, 3};  // scissors 2 beats paper 1 and lizard 3
        List<int> rule3LizardBeats = new List<int>() {1, 4};    // lizard 3 beats paper 1 and spock 4
        List<int> rule4SpockBeats = new List<int>() {0, 2};     // spock 4 beats rock 0 and scissors 2

        // Could build list of verbs & add to the rules object, but I'm not sure how...
        // temporarily will build a list of verbs;  if time allows Tuesday morning, I will add it
        // & incorporate the verbs with the selections. 
        // Note Tuesdsay morning:  finished at 9, decided to help fellow student with last remaining hour.
        // build list to hold verbs
        // Note:  The following list of verbs should be moved to the UserInterface class, 
        // so that it would be easy to change just the UserInterface 
        // in order to use another language
        List<List<string>> verbs = new List<List<string>>();
        // build each individual verb list
        List<string> rule0RockBeatsVerbs = new List<string>() { " crushes ", " crushes " };      // rock 0 beats scissors 2 & lizard 3
        List<string> rule1PaperBeatsVerbs = new List<string>() { " covers ", " disproves " };     // paper 1 beats rock 0 & spock 4
        List<string> rule2ScissorsBeatsVerbs = new List<string>() { " cuts " , " stabs " };  // scissors 2 beats paper 1 and lizard 3         
        List<string> rule3LizardBeatsVerbs = new List<string>() { " eats ", " poisons " };    // lizard 3 beats paper 1 and spock 4
        List<string> rule4SpockBeatsVerbs = new List<string>() { " vaporizes ", " smashes " };     // spock 4 beats rock 0 and scissors 2

        // If I implement more than 2 players, change gameWinnerRoundCount to calculate based on number of 
        // players - winner must win a majority of rounds
        // change gameWinnerRoundCount to be equal to one more than half of the players, or
        // (players.count / 2) + 1
        int gameWinnerRoundCount = 2;  

        public Rules()
        {
            rules.Add(rule0RockBeats);
            rules.Add(rule1PaperBeats);
            rules.Add(rule2ScissorsBeats);
            rules.Add(rule3LizardBeats);
            rules.Add(rule4SpockBeats);

            verbs.Add(rule0RockBeatsVerbs);
            verbs.Add(rule1PaperBeatsVerbs);
            verbs.Add(rule2ScissorsBeatsVerbs);
            verbs.Add(rule3LizardBeatsVerbs);
            verbs.Add(rule4SpockBeatsVerbs);
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
            int indexOfSelections;
            string whatDefeatsWhatAndHow = "";
            List<string> thisRoundWinnerVerbs;
            int roundWinnerPlayerNumber;
            int roundLoserPlayerNumber;

            do
            {
                // if the 2nd player's choice is in the 1st player's choice Beats list, 
                //      the 1st player wins, else the 2nd player wins
                // This is necessary for more than 2 players;  
                // however more than 2 players has not been tested
                
                // Check for all players with the same selection
                if (players[playerToBeat].GetCurrentSelection() == players[i + 1].GetCurrentSelection())
                {
                    roundEndsInTie = true;
                }
                else
                {
                    // if there is more than two players, compare the selections of each pair, 
                    // and store the winner in playerToBeatSelectionBeatsList
                    List<int> playerToBeatSelectionBeatsList = new List<int>();
                    playerToBeatSelectionBeatsList = rules[players[playerToBeat].GetCurrentSelection()];
                    indexOfSelections = playerToBeatSelectionBeatsList.IndexOf(players[i + 1].GetCurrentSelection());
                    //if (playerToBeatSelectionBeatsList.IndexOf(players[i + 1].GetCurrentSelection()) >= 0)
                    if (indexOfSelections >= 0)
                    {
                        // construct message of what defeated what & how
                        // playerToBeat won this round
                        roundWinnerPlayerNumber = playerToBeat;
                        roundLoserPlayerNumber = i + 1;
                        playerToBeat = i;   // first user beats second
                        roundEndsInTie = false;
                    }
                    else
                    {
                        // construct message of what defeated what & how
                        // player i + 1 won this round, playerToBeat lost
                        roundWinnerPlayerNumber = i + 1;
                        roundLoserPlayerNumber = playerToBeat;
                        playerToBeatSelectionBeatsList = rules[players[roundWinnerPlayerNumber].GetCurrentSelection()];
                        indexOfSelections = playerToBeatSelectionBeatsList.IndexOf(players[roundLoserPlayerNumber].GetCurrentSelection());
                        playerToBeat = i + 1;// second user beats first
                        roundEndsInTie = false;
                    }
                    thisRoundWinnerVerbs = verbs[players[roundWinnerPlayerNumber].GetCurrentSelection()];
                    whatDefeatsWhatAndHow = UserInterface.selectionNames[players[roundWinnerPlayerNumber].GetCurrentSelection()] +
                        thisRoundWinnerVerbs[indexOfSelections] +
                        UserInterface.selectionNames[players[roundLoserPlayerNumber].GetCurrentSelection()];
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
                return whatDefeatsWhatAndHow + "; " + players[playerToBeat].name + " wins this round.  Please press Enter/Return to continue";
            }
        }
        public bool gameOver(List<Player> players)
        {
            // loop through the players, if one has a score of gameWinnerRoundCount , 
            // display the scores of each player & congratulate the winner, & return true
            foreach (Player thisPlayer in players)
            {
                if (thisPlayer.score >= gameWinnerRoundCount)
                {
                    // congratulate winner
                    UserInterface.displayMessage(thisPlayer.name + " wins!", false);
                    return true;
                }
            }
            return false;
        }
        public string getListOfWhatBeatsWhatAndHow()
        {
            // Construct list of Paper covers Rock, etc.
            List<int> selectionBeatsList;// = new List<int>();
            List<string> listOfVerbsThisSelection;
            string listOfWhatBeatsWhatAndHow = "Here are the rules:\n";
            for (int i = 0; i < rules.Count; i++)
            {
                selectionBeatsList = rules[i];
                listOfVerbsThisSelection = verbs[i];
                for (int j = 0; j < listOfVerbsThisSelection.Count; j++)
                {
                    listOfWhatBeatsWhatAndHow = listOfWhatBeatsWhatAndHow +
                        UserInterface.selectionNames[i] + listOfVerbsThisSelection[j] +
                        UserInterface.selectionNames[ selectionBeatsList[j]] + "\n";
                }
            }
            listOfWhatBeatsWhatAndHow = listOfWhatBeatsWhatAndHow + "In order to win the game, you must win a majority of rounds.  Good luck!";
            return listOfWhatBeatsWhatAndHow;
        }
    }
}
