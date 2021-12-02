using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_5
{
    public class Rectangle : Figure 
    {
        public Rectangle(int x, int y, int x2, int y2) : base(x, y)
        {
            X2 = x2;
            Y2 = y2;
        }

        public int X2 { get; set; }
        public int Y2 { get; set; }

        public override string Draw()
        {
            return string.Format("Фигура прямоугольник:\n" +
                "точка A (X:{0}, Y:{1});\n" +
                "точка B (X:{0}, Y:{2});\n" +
                "точка C (X:{3}, Y:{2});\n" +
                "точка D (X:{3}, Y:{1});", X, Y, X2, Y2);
            throw new NotImplementedException();
        }
    }
}
