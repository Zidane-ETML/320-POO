namespace ParaClub
{
    public class Plane
    {
        List<Para>paras = new List<Para>();
        private int _x = 0;
        private string[] view =
        {
                @" _                         ",
                @"| \                        ",
                @"|  \       ______          ",
                @"--- \_____/  |_|_\____  |  ",
                @"  \_______ --------- __>-} ",
                @"        \_____|_____/   |  "
        };
        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, i);
                Console.WriteLine(view[i]);
            }
        }
        public void update()
        {
            Console.Clear();
            _x += 1;
            _x %= Config.SCREEN_WIDTH;
            Console.SetCursorPosition(_x, 0);
        }
        public void board(Para p)
        {
            paras.Add(p);
        }
        public void pushpara(Para p)
        {
            paras.Remove(p);
        }
    }
}
