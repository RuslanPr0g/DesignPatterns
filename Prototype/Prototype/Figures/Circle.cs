using System;

namespace Prototype
{
    class Circle : IFigure
    {
        int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            //return new Circle(this.radius);
            return this.MemberwiseClone() as IFigure;
        }

        public void GetInfo()
        {
            Console.WriteLine("Radius: {0}", radius);
        }
    }
}
