using Castle.Windsor;
using MazeGameV2_0;

namespace MazeGameV2_0

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcone();

            WindsorContainer Container = new WindsorContainer("D:\\ProjectsTraning\\MazeGame\\MazeGameV2.0\\App.config");
            var  Game = Container.Resolve<MazeGame>();
            Game.Creation(60, 40, Container);

           


        }

        private static void Welcone()
        {
            Console.WriteLine("ALL CopyRights is reserved ");
            Console.WriteLine("[Mohamed Amin]");
            Console.WriteLine("Hello Man!");
            Console.WriteLine("Please Enter Your Player Name......>");
            var PlayerName = Console.ReadLine();
            Console.WriteLine($"hello {PlayerName} \n The game will be starting Soooon");
            Console.WriteLine("Loading ...");
            Thread.Sleep(3000);
        }
    }
}
