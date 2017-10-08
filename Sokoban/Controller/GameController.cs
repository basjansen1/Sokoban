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

    public Game Game1
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public PlayGround PlayGround1
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public Square Square
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    private short level;
    private ViewController viewController;
    private GameView gameView;

    public GameController()
    {
        this.PlayGround = new PlayGround(this);
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

            switch (keyinfo.Key)
            {
                // Change the ID of the squares(currSquareID)
                case ConsoleKey.UpArrow:
                    PlayGround.Spike.MoveUp(PlayGround.PlayField);
                    PlayGround.UpdatePlayRound();
                    break;
                case ConsoleKey.DownArrow:
                    PlayGround.Spike.MoveDown(PlayGround.PlayField);
                    PlayGround.UpdatePlayRound();
                    break;
                case ConsoleKey.LeftArrow:
                    PlayGround.Spike.MoveLeft(PlayGround.PlayField);
                    PlayGround.UpdatePlayRound();
                    break;
                case ConsoleKey.RightArrow:
                    PlayGround.Spike.MoveRight(PlayGround.PlayField);
                    PlayGround.UpdatePlayRound();
                    break;
                case ConsoleKey.S:
                    ResetPuzzle();
                    Console.Clear();
                    new GameController().SetupGame();
                    break;
                case ConsoleKey.R:
                    ResetPuzzle();
                    PlayGround.GenerateLevel(level);
                    break;
            }
        }
        while (keyinfo.Key != ConsoleKey.S || keyinfo.Key != ConsoleKey.R);
    }

    private void ResetPuzzle()
    {
        PlayGround.PlayField.Clear();
        PlayGround.Boxes.Clear();
        PlayGround.levelCompleted = false;
    }

    public void PrintField(Dictionary<string, Square> playField)
    {
        gameView.PrintField(playField);
    }
}