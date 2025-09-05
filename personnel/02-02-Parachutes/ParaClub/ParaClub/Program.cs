using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
            Console.WriteLine("Hello World!");
        }
        static class Config
        {
            public const int SCREEN_HEIGHT = 40;
            public const int SCREEN_WIDTH = 150;
        }
    }
}