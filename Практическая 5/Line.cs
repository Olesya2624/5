using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_5
{
    public class Line : Figure
    {
        public Line(int x, int y, int endX, int endY) : base(x, y)
        {
            EndX = endX;
            EndY = endY;
        }

        public int EndX { get; set; }
        public int EndY { get; set; }

        public override string Draw()
        {
            return string.Format("Фигура линия:\nначальная точка (X:{0}, Y:{1});\nконечная точка (X:{2}, Y:{3})", X, Y, EndX, EndY);
            throw new NotImplementedException();
        }
    }
}

