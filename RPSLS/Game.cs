using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Firstly, you will select the number of people that will be playing. Next, you duel! Here are the rules to the game:");

            Console.WriteLine("Rock crushes Scissors" +
                "Scissors cuts Paper" +
                "Paper covers Rock" +
                "Rock crushes Lizard" +
                "Lizard poisons Spock" +
                "Spock smashes Scissors" +
                "Scissors decapitates Lizard" +
                "Lizard eats Paper" +
                "Paper disproves Spock" +
                "Spock vaporizes Rock");

            Console.WriteLine("Game will be best out of 3 rounds!" +
                "Good luck!");

        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many players will be deuling today?");
            string numberOfHumanPlayers = Console.ReadLine();
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
