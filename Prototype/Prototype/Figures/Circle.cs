using System;

namespace Prototype
{
    class Circle : IFigure
    {
        int radius;

        public Point Point { get; set; }

        public Circle(int r, int x, int y)
        {
            radius = r;
            this.Point = new Point { X = x, Y = y };
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }

        public void GetInfo()
        {
            Console.WriteLine("Radius {0} and center: ({1}, {2})", radius, Point.X, Point.Y);
        }
    }
}
