﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

public abstract class Square
{
    // Properties
	public Boolean Available {
        get
        {
            return box == null;
        }
        set
        {
            Available = value;
        }
    }
	public int Row { get; set; }
	public int Column { get; set; }
    public Box box {
        get
        {
            return box;
        }
        set
        {
            if (Available)
            {
                box = value;
            }
        }
    }
    public Player player {
        get
        {
            return player;
        }
        set
        {
            if (Available)
            {
                player = value;
            }
        }
    }

    // Constructor
    public Square(int row, int column) 
    {
        Row = row;
        Column = column;
    }

    // Methods

    //Return the Row and Column in string format, like "1:15"
    public string ID {
        get {
            return Row + ":" + Column;
        }
    }

    public void RemoveMovableObject()
	{
        box = null;
	}
    public abstract void print();
}

