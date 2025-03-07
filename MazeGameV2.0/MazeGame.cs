using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGameV2_0
{
    internal class MazeGame
    {
        
       
    
        public void Creation(int Width, int Height, WindsorContainer C)
        {
            
            var _player = new Character();

            var BoundaryOfGame = C.Resolve<IMazeGameShape>();
            BoundaryOfGame.Draw(Width, Height, C);
        }

    }
}
