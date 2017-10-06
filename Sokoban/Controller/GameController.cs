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
    private short level;

    public GameController()
    {
        this.PlayGround = new PlayGround();
        this.Game = new Game();
    }

    private void ShowMenu()
    {
        Console.WriteLine("------------------------------------------------------");

        for (int i = 0; i < 11; i++)
        {
            if (i == 0) Console.WriteLine("| Welkom bij Sokoban                                 |");
            else if (i == 1) Console.WriteLine("|                                                    |");
            else if (i == 2) Console.WriteLine("| betekenis van de symbolen  |  doel van het spel    |");
            else if (i == 3) Console.WriteLine("|                                                    |");
            else if (i == 4) Console.WriteLine("| spatie : outerspace        |  duw met de truck     |");
            else if (i == 5) Console.WriteLine("|      █ : muur              |  de krat(ten)         |");
            else if (i == 6) Console.WriteLine("|      . : vloer             |  naar de bestemming   |");
            else if (i == 7) Console.WriteLine("|      O : krat              |                       |");
            else if (i == 8) Console.WriteLine("|      0 : krat op bestemming|                       |");
            else if (i == 9) Console.WriteLine("|      X : bestemming        |                       |");
            else if (i == 10) Console.WriteLine("|      @  : truck            |                       |");
        }

        Console.WriteLine("------------------------------------------------------");
    }

    public void SetupGame()
    {
        ShowMenu();

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

        ConsoleKeyInfo keyinfo;
        do
        {
            keyinfo = Console.ReadKey();

            if (PlayGround.CheckLevelCompleted())
            {
                Console.WriteLine("Wilt u teruggaan naar het menu? y/n");
                string input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    Game = null;
                    Game = new Game();

                    this.SetupGame();
                }
            }

            PlayGround.ProcessUserInput(keyinfo);
        }
        while (keyinfo.Key != ConsoleKey.S || keyinfo.Key != ConsoleKey.R);
    }
}