using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new GameController().SetupGame();

            Console.ReadKey();
        }
    }
}
