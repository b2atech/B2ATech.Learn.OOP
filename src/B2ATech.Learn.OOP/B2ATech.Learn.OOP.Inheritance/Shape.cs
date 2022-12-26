using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2ATech.Learn.OOP.Inheritance
{
    /// <summary>
    /// The following example defines an abstract base class named Shape that defines two properties: Area and Perimeter.
    /// </summary>
    public abstract class Shape
    {
        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        public override string ToString() => GetType().Name;

        public static double GetArea(Shape shape) => shape.Area;

        public static double GetPerimeter(Shape shape) => shape.Perimeter;
    }
}
