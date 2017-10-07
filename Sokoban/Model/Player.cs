using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public abstract class Player // Spike and Collaborator extends this class, note that Collaborator also has to implement the interface
    {
        public abstract void moveUp(Dictionary<string, Square> PlayField);
        public abstract void moveDown(Dictionary<string, Square> PlayField);
        public abstract void moveRight(Dictionary<string, Square> PlayField);
        public abstract void moveLeft(Dictionary<string, Square> PlayField);
    }
}
