using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_5
{
    public class Ring : Circle
    {
        public Ring(int x, int y, int radius, int maxradius) : base(x, y, radius)
        {
            Maxradius = maxradius;
        }
        public int Maxradius { get; set; }

        public override string Draw()
        {
            return string.Format("Фигура кольцо:\nцентр (X:{0}, Y: {1});\nвнутренний радиус: {2};\nвнешний радиус: {3}", X, Y, Radius, Maxradius);
        }
    }
}
