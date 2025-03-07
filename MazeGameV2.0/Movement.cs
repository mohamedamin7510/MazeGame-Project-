using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGameV2_0
{
    internal class Movement : IMovement
    {
       
        public void  UpdateMovement(int Width, int Height, WindsorContainer Container)
        {
          
            while (Character.X < Width -1)
            {
                ConsoleKeyInfo Step = Console.ReadKey();
                switch (Step.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (!MazeGameShape.Pixels[Character.Y - 1, Character.X].IsSolid()  )
                        {
                            Character.Y -= 1;
                        }
                        break;


                    case ConsoleKey.DownArrow:
                        if (!MazeGameShape.Pixels[Character.Y + 1, Character.X].IsSolid())
                        {
                            Character.Y += 1;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (!MazeGameShape.Pixels[Character.Y, Character.X + 1].IsSolid())
                        {
                            
                            Character.X += 1;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (!MazeGameShape.Pixels[Character.Y, Character.X - 1].IsSolid())
                        {
                            Character.X -= 1;
                        }

                        break;


                }
                var NewPostionPainted = Container.Resolve<MazeGame>();
                NewPostionPainted.Creation(Width, Height, Container);


            }

        }
    }
}
