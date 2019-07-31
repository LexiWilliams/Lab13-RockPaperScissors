using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Rock_Paper_Scissors
{
    abstract class Player
    {
        public string Name { get; set; }
        public Roshambo Roshambo { get; set; }

        public Player()
        {

        }
        public Player(Roshambo roshambo)
        {
            Roshambo = roshambo;
        }

        public abstract Roshambo GenerateRoshambo();
    }
}
