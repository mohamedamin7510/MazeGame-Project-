using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGameV2_0
{
    internal class MazeGameShape : IMazeGameShape
    {
      
        WindsorContainer WindsorContainer { get; set; }
        
        public static IMazeObjects[,] Pixels;
        public void Draw(int W, int H, WindsorContainer C)
        {
            WindsorContainer = C;
            Pixels = new IMazeObjects[H, W];
            Console.Clear();
            for (int i = 0; i < H; i++)
            {

                for (int j = 0; j < W; j++)
                {
                    if (i == 0 || i == H - 1)
                    {

                        Pixels[i, j] = WindsorContainer.Resolve<IMazeObjects>("WallIntalizer");
                        Console.Write(Pixels[i, j]._icon);

                    }
                    else if (i == Character.Y && j == Character.X)
                    {
                        Pixels[i, j] = WindsorContainer.Resolve<IMazeObjects>("CharacterIntalizer");
                        Console.Write(Pixels[i, j]._icon);
                    }
                    else if ((i == 3 && j == 0) || (i == H - 2 && j == W - 1))
                    {
                        Pixels[i, j] = WindsorContainer.Resolve<IMazeObjects>("EmptySpaceIntalizer");
                        Console.Write(Pixels[i, j]._icon);
                    }
                    else if (j == 15 && i < H - 10 )
                    {
                        Pixels[i, j] = WindsorContainer.Resolve<IMazeObjects>("WallIntalizer");
                        Console.Write(Pixels[i, j]._icon);
                    }
                    else if (j == 0 || j == W - 1)
                    {
                        Pixels[i, j] = WindsorContainer.Resolve<IMazeObjects>("WallIntalizer");
                        Console.Write(Pixels[i, j]._icon);
                    }
                    else
                    {
                        Pixels[i, j] = WindsorContainer.Resolve<IMazeObjects>("EmptySpaceIntalizer");
                        Console.Write(Pixels[i, j]._icon);
                    }
                   
                    
                    
                    
                }
                Console.WriteLine();


            }
            IMovement CV = new Movement();
            CV.UpdateMovement(60, 40, C);
        }
    }
}
