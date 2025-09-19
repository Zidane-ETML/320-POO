using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Factory:Building
    {
        public int PowerConsumption = Helpers.RandomHelpers.alea.Next(2400, 24000);
        private Pen buildingBrushFac = new Pen(new SolidBrush(Color.Blue), 3);

        public Factory() : base()
        {
            
        }
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrushFac, new Rectangle(_x, _y, large, large));
        }

    }
}
