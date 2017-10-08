using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public class Collaborator : Movable, IPlayer
    {
        public bool Awake { get; set; }
        public bool Touched { get; set; }

        public void MoveDown(Dictionary<string, Square> PlayField)
        {
            string newSquareID = Square.Row + ":" + (Square.Column + 1); // represents the square the player want to move to
            string squareNextToNewSquareID = Square.Row + ":" + (Square.Column + 2); // represent the next square from toMoveSquare
            string squareNextToNextSquareID = Square.Row + ":" + (Square.Column + 3); // represent the next square from the next Square

            this.DoMove(PlayField, newSquareID, squareNextToNewSquareID, squareNextToNextSquareID);
        }

        public void MoveLeft(Dictionary<string, Square> PlayField)
        {
            string newSquareID = (Square.Row - 1) + ":" + Square.Column; // represents the square the player want to move to
            string squareNextToNewSquareID = (Square.Row - 2) + ":" + Square.Column; // represent the next square from toMoveSquare
            string squareNextToNextSquareID = (Square.Row - 3) + ":" + Square.Column; // represent the next square from the next Square

            this.DoMove(PlayField, newSquareID, squareNextToNewSquareID, squareNextToNextSquareID);
        }

        public void MoveRight(Dictionary<string, Square> PlayField)
        {
            string newSquareID = (Square.Row + 1) + ":" + Square.Column; // represents the square the player want to move to
            string squareNextToNewSquareID = (Square.Row + 2) + ":" + Square.Column; // represent the next square from toMoveSquare
            string squareNextToNextSquareID = (Square.Row + 3) + ":" + Square.Column; // represent the next square from the next Square

            this.DoMove(PlayField, newSquareID, squareNextToNewSquareID, squareNextToNextSquareID);
        }

        public void MoveUp(Dictionary<string, Square> PlayField)
        {
            string newSquareID = Square.Row + ":" + (Square.Column - 1); // represents the square the player want to move to
            string squareNextToNewSquareID = Square.Row + ":" + (Square.Column - 2); // represent the next square from toMoveSquare
            string squareNextToNextSquareID = Square.Row + ":" + (Square.Column - 3); // represent the next square from the next Square

            this.DoMove(PlayField, newSquareID, squareNextToNewSquareID, squareNextToNextSquareID);
        }

        private void DoMove(Dictionary<string, Square> PlayField, string newSquareID, string squareNextToNewSquareID, string squareNextToNextSquareID)
        {
            Square toMoveSquare; // represents the square the collaborator wants to stand on
            PlayField.TryGetValue(newSquareID, out toMoveSquare);
            Square nextSquare = null; // represent the next square from toMoveSquare, necessary for moving a movable
            Square nextToNextSquare = null; // represent the next square to next square, necessary for moving a movable

            if (!toMoveSquare.Available)
            {
                return; // return without moving
            }

            if (toMoveSquare.MovableObject != null) // if the square contains a movableObject / is available
            {
                // find out whether the next square the movable has to move to is available
                PlayField.TryGetValue(squareNextToNewSquareID, out nextSquare);
                if (!nextSquare.Available)
                {
                    return; // return without moving
                }
                else if (nextSquare.MovableObject != null) // if the square contains a movableObject 
                {
                    PlayField.TryGetValue(squareNextToNextSquareID, out nextToNextSquare);
                    if (!nextToNextSquare.Available || nextToNextSquare.MovableObject != null)
                    {
                        return; // return without moving anything
                    } else
                    {
                        nextSquare.MovableObject.Replace(nextSquare, nextToNextSquare); // move the movable
                    }
                }
                toMoveSquare.MovableObject.Replace(toMoveSquare, nextSquare); // move the movable
            }
            this.Replace(this.Square, toMoveSquare); // move Collaborator
        }

        public bool CalculateAwake()
        {
            if (Touched)
                Awake = true;

            if (Awake)
            {
                if (GetRandom(1, 4) == 2)
                    Awake = false;
            }
            else
            {
                if (GetRandom(1, 11) == 5)
                    Awake = true;
                else
                    Awake = false;
            }

            return Awake;
        }

        private int GetRandom(int sRange, int eRange)
        {
			Random r = new Random();

            return r.Next(sRange, eRange);
        }
    }
}
