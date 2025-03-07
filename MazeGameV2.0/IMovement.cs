using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGameV2_0
{
    internal interface IMovement
    {
        public void UpdateMovement(int Width , int Height , WindsorContainer Container);
        
      
    }
}
