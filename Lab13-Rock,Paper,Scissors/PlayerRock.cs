using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Rock_Paper_Scissors
{
    class PlayerRock :Player
    {

        public PlayerRock()
        {
            Name = "Tornado";
            Roshambo = GenerateRoshambo();
        }
        public override Roshambo GenerateRoshambo() //always rock
        {
            return Roshambo.rock;
        }
       
    }
}
