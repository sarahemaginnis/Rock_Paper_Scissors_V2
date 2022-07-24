using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_V2
{
    public class Computer
    {
        public string ComputerChoice = "";
        public Random random = new Random();

        public string ComputerChoiceDetermination()
        {
            switch(random.Next(1, 4))
            {
                case 1:
                    ComputerChoice = Options.graphics[Options.Choices.Rock];
                    break;
                case 2:
                    ComputerChoice = Options.graphics[Options.Choices.Paper];
                    break;
                case 3:
                    ComputerChoice = Options.graphics[Options.Choices.Scissors];
                    break;
            }
            return ComputerChoice;
        }
    }
}
