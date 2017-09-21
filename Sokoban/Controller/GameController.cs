/**
 * @Author: Bas Jansen
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GameController
{
    public PlayGround PlayGround { get; set; }
    public Game Game { get; set; }
	public SocobanPresentation SocobanPresentation { get; set; }

    public GameController()
    {
        this.PlayGround = new PlayGround();
        this.Game = new Game();
        this.SocobanPresentation = new SocobanPresentation();
    }

    public void SetupGame()
    {
        string input;
        Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");

        while (true)
        {
            input = Console.ReadLine();

            if (input == "1" || input == "2" || input == "3" || input == "4" || input == "s")
            {
                if (input == "s") return;

                short level;
                Int16.TryParse(input, out level);

                PlayGround.GenerateLevel(level);
                this.PlayGame();
            }
            else
            {

                Console.WriteLine("?");
                continue;
            }
        }
    }

    public void PlayGame()
    {

    }
}

