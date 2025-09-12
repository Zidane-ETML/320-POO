using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Building
    {
        private int _x = Helpers.RandomHelpers.alea.Next(3, AirSpace.WIDTH);
        private int _y = Helpers.RandomHelpers.alea.Next(3, AirSpace.HEIGHT);
        private int large = Helpers.RandomHelpers.alea.Next(40, 65);
        private int deep = Helpers.RandomHelpers.alea.Next(40, 65);
        private Pen buildingBrush = new Pen(new SolidBrush(Color.Black), 3);

        
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(_x, _y, large, deep));
        }
    }
}
