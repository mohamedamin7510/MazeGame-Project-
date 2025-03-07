using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGameV2_0
{
    internal class Wall : IMazeObjects
    {
        public string _icon => "*";
        public bool IsSolid() => true;

    }
}
