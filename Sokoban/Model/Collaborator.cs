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
    }
}
