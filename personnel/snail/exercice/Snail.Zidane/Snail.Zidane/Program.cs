using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string snail = "_@_ö";
            int position = 0;
            for (int i = 50; i > 0; i--)
            {
                Thread.Sleep(50);
                Console.Clear();
                Console.SetCursorPosition(position, 0);
                Console.WriteLine(snail);
                position++;
            }
            Console.Clear();
            Console.SetCursorPosition(position, 0);
            Console.WriteLine("____");
            Console.ReadLine();
        }
    }
}