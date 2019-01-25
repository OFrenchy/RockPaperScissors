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
