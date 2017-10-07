using Sokoban.Controller;
using Sokoban.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GameController
{
    public PlayGround PlayGround { get; }
    public Game Game { get; set; }
    private short level;
    private ViewController viewController;
    private GameView gameView;

    public GameController()
    {
        this.PlayGround = new PlayGround();
        this.Game = new Game();
        this.viewController = new ViewController();
        this.gameView = new GameView();
    }

    public void SetupGame()
    {
        gameView.ShowMenu();
        level = viewController.AskInput();

        if (level != -1 || level != 0)
            PlayGame();
        else
        {
            Console.WriteLine("Verkeerde data ingevuld! Probeer het opnieuw.");
            SetupGame();
        }
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