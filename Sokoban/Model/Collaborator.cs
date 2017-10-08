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
            throw new NotImplementedException();
        }

        public void MoveLeft(Dictionary<string, Square> PlayField)
        {
            throw new NotImplementedException();
        }

        public void MoveRight(Dictionary<string, Square> PlayField)
        {
            throw new NotImplementedException();
        }

        public void MoveUp(Dictionary<string, Square> PlayField)
        {
            throw new NotImplementedException();
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
