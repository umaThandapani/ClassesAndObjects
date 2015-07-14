using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class TheGame
    {

        int player;
        int level;
        public TheGame()
        {
            player = 0;
            level = 0;
        }

        public void Greeting()
        {
            Console.WriteLine("Welcome code crusader!");
            Console.WriteLine("How many adventurers are in your group?");
        }


        //    public static void (int level)
        //{


        //}
        public void adventure()
        {

            do
            {
                Console.WriteLine("Would you like to complete the project alone or with a friend? ");
                Console.WriteLine("Type 1 to program alone or 2 to program with a friend");
                //level = incrementLevel(int.Parse(Console.ReadLine()));
                level = incrementLevel(int.Parse(Console.ReadLine()), level);
                Console.WriteLine("");
            } while (level <= 26);
        }

        ////public static int incrementLevel(int input)
        ////{

        ////    input++;
        ////    return rank(input);
        ////}
        public static int incrementLevel(int choice, int level)
        {
            if (choice == 1)
            {
                level++;
            }
            else if (choice == 2)
            {
                level++;
                level++;
            }
            rank(level);    // just prints a statement!
            return level;
        }

        //public static int rank(int rankInteger)
        public static void rank(int rankInteger)
        {
            switch (rankInteger)
            {
                case 5:
                    {
                        Console.WriteLine("Congratulations!!! You are now a Grasshopper rank developer");
                        break;
                    }

                case 10:
                    {
                        Console.WriteLine("Congratulations!!! You are now a JourneyMan rank developer");
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("Congratulations!!! You are now a RockStar rank developer");
                        break;
                    }
                case 20:
                    {
                        Console.WriteLine("Congratulations!!! You are now a Ninja rank developer" + rankInteger + "!");
                        break;
                    }
                case 25:
                    {
                        Console.WriteLine("Congratulations!!! You are now a Jedi rank developer");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Congratulations!!! You are now a " + rankInteger + " level developer!");
                        break;
                    }
            }//End Of Switch


            //return rankInteger;

        }

        
    }
}
