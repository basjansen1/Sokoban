using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public interface IPlayer
    {
        Collaborator Collaborator { get; set; }
        Spike Spike { get; set; }

        void MoveUp(Dictionary<string, Square> PlayField);
        void MoveDown(Dictionary<string, Square> PlayField);
        void MoveRight(Dictionary<string, Square> PlayField);
        void MoveLeft(Dictionary<string, Square> PlayField);
    }
}
