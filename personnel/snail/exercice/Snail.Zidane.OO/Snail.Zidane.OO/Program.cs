using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Snail snail1 = new Snail(500, "_@_ö");
            snail1.race();


        }
        class Snail
        {
            private int _speed;
            private string _form;

            public Snail(int speed, string form)
            {
                this._speed = speed;
                this._form = form; 
            }
            public void race()
            {
                Console.CursorVisible = false;

                int position = 0;
                for (int i = 50; i > 0; i--)
                {
                    Thread.Sleep(_speed);
                    Console.Clear();
                    Console.SetCursorPosition(position, 0);
                    Console.WriteLine(_form);
                    position++;
                }
                Console.Clear();
                Console.SetCursorPosition(position, 0);
                Console.WriteLine("____");
                Console.ReadLine();
            }
        }
    }
}