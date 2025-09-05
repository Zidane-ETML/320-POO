namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
            Plane plane = new Plane();
            Para Bob = new Para();
            plane.board(Bob);
            while (true)
            {
                plane.update();

                plane.draw();

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else if (key.Key == ConsoleKey.Spacebar)
                    {

                    }

                }
            }
        } 

        
    }
}