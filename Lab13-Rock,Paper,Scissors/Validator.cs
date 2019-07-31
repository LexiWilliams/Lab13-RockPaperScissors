using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab13_Rock_Paper_Scissors
{
    class Validator
    {
        public static string GetName(string message)
        {
            Console.Write(message);
            string name = Console.ReadLine();
            if (Regex.IsMatch(name, @"^[a-zA-Z]+[ ]*[a-zA-Z]*$"))
            {
                Console.WriteLine("");
                return name;
            }
            else
            {
                Console.WriteLine("That is not a valid name.\n");
                return GetName(message);
            }
        }
        public static int ChooseOpponent(string message, List<Player> list)
        {
            Console.WriteLine(message);
            int count = 0;
            foreach (Player x in list)
            {
                count++;
                Console.WriteLine($"\t{count}. {x.Name}");
            }
            Console.WriteLine("");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                if (num > 0 && num <= count)
                {
                    return num - 1;
                }
                else
                {
                    Console.WriteLine("That isn't an option.");
                    return ChooseOpponent(message, list);
                }
            }
            else
            {
                Console.WriteLine("That isn't an option.");
                return ChooseOpponent(message, list);
            }
        }
        public static void ChooseRoshambo(PlayerUser user)
        {
            Console.WriteLine($"\nChoose one:\n\t1.{Roshambo.rock}\n\t2.{Roshambo.paper}\n\t3.{Roshambo.scissors}");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                if (num == 1)
                {
                    user.Roshambo = Roshambo.rock;
                }
                else if (num == 2)
                {
                    user.Roshambo = Roshambo.paper;
                }
                else if (num == 3)
                {
                    user.Roshambo = Roshambo.scissors;
                }
                else
                {
                    Console.WriteLine("That isn't an option.");
                    ChooseRoshambo(user);
                }
            }
        }
        public static bool PlayAgain(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
            {
                return true;
            }
            else if (input == "no")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("\nThat input is invaid.\n");
                return PlayAgain(message);
            }
        }
    }
}
