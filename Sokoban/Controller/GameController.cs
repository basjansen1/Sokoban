/**
 * @Author: Bas Jansen
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GameController
{
    public PlayGround PlayGround { get; }
    public Game Game { get; set; }
    public SocobanPresentation SocobanPresentation { get; set; }
    private short level;

    public GameController()
    {
        this.PlayGround = new PlayGround();
        this.Game = new Game();
        this.SocobanPresentation = new SocobanPresentation();
    }

    public void SetupGame()
    {
        Console.WriteLine("> Kies een doolhof (1 - 4), s = stop");

        ConsoleKeyInfo keyInfo;
        do
        {
            keyInfo = Console.ReadKey();
            Console.WriteLine();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    level = 1;
                    break;
                case ConsoleKey.D2:
                    level = 2;
                    break;
                case ConsoleKey.D3:
                    level = 3;
                    break;
                case ConsoleKey.D4:
                    level = 4;
                    break;
            }

            Console.WriteLine(level);
            if (level != 0)
                PlayGame();
            else
                continue;
        } while (keyInfo.Key != ConsoleKey.D1 && keyInfo.Key != ConsoleKey.D2 && keyInfo.Key != ConsoleKey.D3 
                        && keyInfo.Key != ConsoleKey.D4);
    }

    public void PlayGame()
    {
        Console.WriteLine("PlayGame");
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