using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Rock_Paper_Scissors
{
    class PlayerUser : Player
    {
        #region Constructors

        public PlayerUser()
        {
           
        }

        #endregion
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine($"\nChoose one:\n\t1.{Roshambo.rock}\n\t2.{Roshambo.paper}\n\t3.{Roshambo.scissors}");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                if (num == 1)
                {
                    return Roshambo.rock;
                }
                else if(num==2)
                {
                    return Roshambo.paper;
                }
                else if (num == 3)
                {
                    return Roshambo.scissors;
                }
            }
                Console.WriteLine("That isn't an option.");
                return GenerateRoshambo();
        }
    }
}
