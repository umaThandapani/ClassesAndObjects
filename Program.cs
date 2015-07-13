using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGame myAdventure = new TheGame();
            myAdventure.Greeting();
            myAdventure.adventure();
        }

    }
}
