using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGameV2_0
{
    internal class EmptySpace : IMazeObjects
    {
        public string _icon => " ";
        public bool IsSolid() => false;
      
    }
}
