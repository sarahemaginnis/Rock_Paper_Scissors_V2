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
        Computer computer = new Computer();

        public int playerPoints = 0;
        public int computerPoints = 0;
        public string WinnerDetermination()
        {
            Options.Choices playerChoiceAsEnum = (Options.Choices)player.PlayerChoiceDetermination();//cast playerChoiceAsInt variable from int to enum;
            switch (playerChoiceAsEnum)
            {
                case Options.Choices.Rock:
                    if (computer.ComputerChoice == Options.graphics[Options.Choices.Rock])
                    {
                        Console.WriteLine("It's a draw!");
                    } else if (computer.ComputerChoice == Options.graphics[Options.Choices.Paper])
                    {
                        computerPoints++;
                    } else
                    {
                        playerPoints++;
                    }
                    break;
                case Options.Choices.Paper:
                    if (computer.ComputerChoice == Options.graphics[Options.Choices.Rock])
                    {
                        playerPoints++;
                    } else if (computer.ComputerChoice == Options.graphics[Options.Choices.Paper])
                    {
                        Console.WriteLine("It's a draw!");
                    } else
                    {
                        computerPoints++;
                    }
                    break;
                case Options.Choices.Scissors:
                    if (computer.ComputerChoice == Options.graphics[Options.Choices.Rock])
                    {
                        computerPoints++;
                    } else if (computer.ComputerChoice == Options.graphics[Options.Choices.Paper])
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
Computer: {computer.ComputerChoice}";
        }
    }
}
