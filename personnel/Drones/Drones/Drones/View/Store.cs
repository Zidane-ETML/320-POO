using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Store:Building
    {
        public string OpeningHours = "Lundi: 8h-18h Mardi: 8h-18h Mercredi: 8h-18h";
        private Pen buildingBrushFac = new Pen(new SolidBrush(Color.Orange), 3);

        public Store() : base()
        {

        }
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(buildingBrushFac, new Rectangle(_x, _y, large, deep));
        }
    }
}
