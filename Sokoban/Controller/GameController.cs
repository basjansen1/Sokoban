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
    private short level;

    public GameController()
    {
        this.PlayGround = new PlayGround();
        this.Game = new Game();
        this.SocobanPresentation = new SocobanPresentation();

        Console.WriteLine("TEST COMMIT");
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

                Int16.TryParse(input, out level);

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
        PlayGround.GenerateLevel(level);

        // TODO-> Print map

        ConsoleKeyInfo keyinfo;
        do
        {
            keyinfo = Console.ReadKey();

            PlayGround.Move(keyinfo);
        }
        while (keyinfo.Key != ConsoleKey.S || keyinfo.Key != ConsoleKey.R);
    }
}

