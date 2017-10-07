using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Controller
{
    public class ViewController
    {
        public short AskInput()
        {
            Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.S:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.D1:
                        return 1;
                    case ConsoleKey.D2:
                        return 2;
                    case ConsoleKey.D3:
                        return 3;
                    case ConsoleKey.D4:
                        return 4;
                }
            } while (keyInfo.Key != ConsoleKey.D1 && keyInfo.Key != ConsoleKey.D2 && keyInfo.Key != ConsoleKey.D3
                        && keyInfo.Key != ConsoleKey.D4);
            return -1;
        }
    }
}
