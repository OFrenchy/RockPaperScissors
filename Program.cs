using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScizzorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out of 65 points
            //Using the concepts of OOP by creating classes and using objects(instances of those classes) to 
            //      interact with each other, create a console version of the classic game Rock Paper Scissors Lizard Spock.
            //User stories:
            //(5 points): As a developer, I want to make good, consistent commits. 
            //(15 points): As a developer, I want to find a way to properly incorporate inheritance into my game.
            //(5 points): As a developer, I want to account for and handle bad user input, ensuring that any user 
            //      input is validated and reobtained if necessary.
            //(10 points): As a developer, I want to store all of the gesture options / choices in a List<T>.
            //(10 points): As a player, I want the correct player to win a given round based on the choices*made 
            //      by each player.
            //(10 points): As a player, I want the game of RPSLS to be at minimum a ‘best of three’ to decide a winner.
            //(10 points): As a player, I want the option of a single player(human vs AI) or a multiplayer 
            //      (human vs human) game.
            //* Rock crushes Scissors
            //Scissors cuts Paper
            //Paper covers Rock
            //Rock crushes Lizard
            //Lizard poisons Spock
            //Spock smashes Scissors
            //Scissors decapitates Lizard
            //Lizard eats Paper
            //Paper disproves Spock
            //Spock vaporizes Rock
            //https://www.youtube.com/watch?v=cSLeBKT7-sM

           //1.Selection – e.g.rock, paper; has name &keyboard shortcut(e.g.Spock & o & index(0 - 4))
            //2.Rule - e.g.rock – paper – paper wins; (0, 1, 1)
            //3.Rules – requires two selections; holds all Rule methods, pronounces winner of each round
            //4.Round – asks for selection from each player, has a roundWinner
            //5.Player – makes selection, has running score, player type(human / computer)
            //6.Players – has playRound, addPlayer
            //7.Game – has players, rules, rounds, , gameOver, pronounceWinner, restartGame
            //8.  (‘Added after lecture) human class, computer class with makeSelection method


            // instantiate Game
            // game.RunGame

            // // private Player[] players;
            Game gameRPSLS = new Game();
            gameRPSLS.playRockPaperScissorsLizardSpock(2);
        }


    }


}
