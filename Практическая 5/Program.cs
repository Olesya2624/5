using System;

namespace Практическая_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(0,0, 2,2);
            Console.WriteLine(line.Draw());
            Console.WriteLine(" ");

            Rectangle rectangle = new Rectangle(0, 0, 5, 3);
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(" ");

            Circle circle = new Circle(1,1, 5);
            Console.WriteLine(circle.Draw());
            Console.WriteLine(" ");

            Round round = new Round(1, 1, 5, "Желтый");
            Console.WriteLine(round.Draw());
            Console.WriteLine(" ");

            Ring ring = new Ring(1, 1, 5, 6);
            Console.WriteLine(ring.Draw());
            Console.WriteLine(" ");
        }
    }
}

