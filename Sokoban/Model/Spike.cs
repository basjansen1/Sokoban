﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Spike : IMovable
{
    public Square Square { get; set; }

    public void Move(Square oldSquare, Square newSquare)
    {
        Square = newSquare;
        newSquare.Spike = this;
        oldSquare.RemoveMovableObject();
    }
}

