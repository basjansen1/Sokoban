﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class PlayGround
{
    public IEnumerable<Box> Box { get; set; }
    public Player Player { get; set; }
    public Dictionary<string, Square> PlayField { get; set; }

    public void CheckLevelCompleted()
    {
        throw new System.NotImplementedException();
    }

    public void ResetPuzzle()
    {
        PlayField.Clear();
    }

    public void CheckMoveValid()
    {
        throw new System.NotImplementedException();
    }

    public void GenerateLevel(int level)
    {
        var projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
        var fullPath = new Uri(projectPath + @"\Doolhof\doolhof" + level + ".txt").LocalPath;

        // Bevat het level(speelveld)
        string[] text = File.ReadAllLines(fullPath);

        foreach (var line in text)
        {
            Console.WriteLine(line);
        }
    }

    public void MovePlayer()
    {
        throw new System.NotImplementedException();
    }

    public void Move(ConsoleKeyInfo pressedKey)
    {
        switch (pressedKey.Key)
        {
            case ConsoleKey.UpArrow:
                Console.WriteLine("UP");
                break;
            case ConsoleKey.DownArrow:
                Console.WriteLine("DOWN");
                break;
            case ConsoleKey.LeftArrow:
                Console.WriteLine("LEFT");
                break;
            case ConsoleKey.RightArrow:
                Console.WriteLine("RIGHT");
                break;
        }
    }

}

