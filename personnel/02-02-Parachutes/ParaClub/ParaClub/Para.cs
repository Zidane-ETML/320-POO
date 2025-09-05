using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Para
    {
        private int _x;
        private bool paraopen;
        private int altitude = 5;
        private string[] withoutParachute =
        {
            @"     ",
            @"     ",
            @"     ",
            @"  o  ",
            @" /░\ ",
            @" / \ ",
            };

        private string[] withParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
            };

        public int X { get => _x; set => _x = value; }

        public void update()
        {

        }
        public void draw()
        {
            if (altitude < Config.SCREEN_HEIGHT / 2)
            {
                paraopen = false;
            }
            else
            {
                paraopen = true;
            }
            if (paraopen == false)
            {
                for (int i = 0; i < withoutParachute.Length; i++)
                {
                    Console.SetCursorPosition(X, altitude);
                    Console.WriteLine(withoutParachute[i]);
                }
            }

        }
        public void pushpara()
        {

        }

    }
}
