using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Building
    {
        protected int _x = Helpers.RandomHelpers.alea.Next(3, AirSpace.WIDTH);
        protected int _y = Helpers.RandomHelpers.alea.Next(3, AirSpace.HEIGHT);
        protected int large = Helpers.RandomHelpers.alea.Next(40, 65);
        protected int deep = Helpers.RandomHelpers.alea.Next(40, 65);
        protected Pen buildingBrush = new Pen(new SolidBrush(Color.Black), 3);

        public Building()
        {
            
        }

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(_x, _y, large, deep));
        }
    }
}
