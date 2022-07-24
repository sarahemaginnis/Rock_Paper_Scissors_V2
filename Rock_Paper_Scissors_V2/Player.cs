using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_V2
{
    public class Player
    {
        public int PlayerChoiceDetermination()
        {
            string playerChoice = Console.ReadLine();
            int playerChoiceAsInt = int.Parse(playerChoice); //convert playerChoice variable from string to int
            return playerChoiceAsInt;
        }
    }
}
