using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.View
{
    public class GameView
    {
        public void PrintField(Square s)
        {
            s.Print();
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
            Console.WriteLine("|      @  : truck            |                       |");

            Console.WriteLine("------------------------------------------------------");
        }
    }
}
