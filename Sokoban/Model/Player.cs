using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public abstract class Player // Spike and Collaborator extends this class, note that Collaborator also has to implement the interface
    {
        public abstract void MoveUp(Dictionary<string, Square> PlayField);
        public abstract void MoveDown(Dictionary<string, Square> PlayField);
        public abstract void MoveRight(Dictionary<string, Square> PlayField);
        public abstract void MoveLeft(Dictionary<string, Square> PlayField);
    }
}
