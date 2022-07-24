using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_V2
{
    public static class Options
    {
        public enum Choices
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }

        public static Dictionary<Choices, string> graphics = new Dictionary<Choices, string>()
        {
            {Choices.Rock, @"    
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)" },
            {Choices.Paper, @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)" },
            {Choices.Scissors, @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)" }
        };
    }
}
