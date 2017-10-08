using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    class PitFallSquare : Square
    {
        public int AmountAddedMovableObjects { get; set; }
        public PitFallSquare(int row, int column) 
            : base(row, column)
        {
            AmountAddedMovableObjects = 0;
        }

        public override void addMovableObject(Movable movable)
        {
            if (movable is Box && AmountAddedMovableObjects >= 3)
            {
                return;
            } else
            {
                MovableObject = movable;
                AmountAddedMovableObjects++;
                CalculateShape();
            }
        }

        public override void CalculateShape()
        {
            if (MovableObject == null)
            {
                PrintShape = "~";
            }
            else if (MovableObject is Spike)
            {
                PrintShape = "@";
            }
            else
            {
                PrintShape = "O";
            }
        }

        public override void RemoveMovableObject()
        {
            MovableObject = null;
            CalculateShape();
        }
    }
}
