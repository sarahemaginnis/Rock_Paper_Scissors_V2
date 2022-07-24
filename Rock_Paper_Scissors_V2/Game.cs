using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_V2
{
    public class Game
    {
        Player player = new Player();
        //public string PlayerChoice = player.PlayerChoice; //import PlayerChoice variable from Player Class
        public int playerChoiceAsInt = int.Parse(player.playerChoice); //convert playerChoice variable from string to int
        Options.Choices playerChoiceAsEnum = (Options.Choices)playerChoiceAsInt;//cast playerChoiceAsInt variable from int to enum
        
        Computer computer = new Computer();
        computer.ComputerChoice = "";
        public string computerChoice = Computer.ComputerChoice; //import ComputerChoice variable from Computer Class

        public int playerPoints = 0;
        public int computerPoints = 0;
        public string WinnerDetermination()
        {
            switch (playerChoiceAsEnum)
            {
                case Options.Choices.Rock:
                    if (computerChoice == Options.graphics[Options.Choices.Rock])
                    {
                        Console.WriteLine("It's a draw!");
                    } else if (computerChoice == Options.graphics[Options.Choices.Paper])
                    {
                        computerPoints++;
                    } else
                    {
                        playerPoints++;
                    }
                    break;
                case Options.Choices.Paper:
                    if (computerChoice == Options.graphics[Options.Choices.Rock])
                    {
                        playerPoints++;
                    } else if (computerChoice == Options.graphics[Options.Choices.Paper])
                    {
                        Console.WriteLine("It's a draw!");
                    } else
                    {
                        computerPoints++;
                    }
                    break;
                case Options.Choices.Scissors:
                    if (computerChoice == Options.graphics[Options.Choices.Rock])
                    {
                        computerPoints++;
                    } else if (computerChoice == Options.graphics[Options.Choices.Paper])
                    {
                        playerPoints++;
                    } else
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    break;
            }
                return $@"Player: {Options.graphics[playerChoiceAsEnum]}
VS
Computer: {computerChoice}";
        }
    }
}
