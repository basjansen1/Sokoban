using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Presentation
{
    public class GameView
    {
        public Controller.ViewController ViewController
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("| Welkom bij Sokoban                                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| betekenis van de symbolen  |  doel van het spel    |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| spatie : outerspace        |  duw met de truck     |");
            Console.WriteLine("|      █ : muur              |  de krat(ten)         |");
            Console.WriteLine("|      . : vloer             |  naar de bestemming   |");
            Console.WriteLine("|      O : krat              |                       |");
            Console.WriteLine("|      0 : krat op bestemming|                       |");
            Console.WriteLine("|      X : bestemming        |                       |");

            Console.WriteLine("------------------------------------------------------");
        }

        public void PrintField(Dictionary<string, Square> playField)
        {
            Console.Clear();

            Console.WriteLine("-------------");
            for (int i = 0; i < 3; i++)
                if (i == 1)
                    Console.WriteLine("| SOKOBAN   |");
                else
                    Console.WriteLine("|           |");
            Console.WriteLine(("-------------"));

            Console.WriteLine("-----------------------------------------------------------");

            foreach (var square in playField)
                if (square.Key.Substring(0, 1).Equals("n"))
                    Console.WriteLine(); // print enter
                else if (square.Key.Substring(0, 1).Equals("e"))
                    Console.Write(" "); // print emtpy square
                else // normal square
                    Console.Write(square.Value.PrintShape);

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("> Gebruik pijltjestoetsen (s = stop, r = reset");
        }
    }
}
