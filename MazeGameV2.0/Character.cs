using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGameV2_0
{

    internal  class Character : IMazeObjects
    {
        public string _icon { get; }="M";
        public  static int X { get; set; } = 0;
        public static int Y { get; set; } = 3;
        public bool IsSolid() => true;
        

    }
}
