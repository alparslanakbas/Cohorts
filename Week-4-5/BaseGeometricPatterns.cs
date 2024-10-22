using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_5
{
    public class BaseGeometricPatterns
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public virtual double AreaCalculator() 
        {
            return Width * Height;
        }
    }


    public class Square : BaseGeometricPatterns
    {
        public Square(double width) 
        {
            Width = width;
            Height = width;
        }
    }

    public class Rectangle : BaseGeometricPatterns
    {
        public Rectangle(double side, double height)
        {
            Width = side;
            Height = height;
        }
    }

    public class RightTriangle : BaseGeometricPatterns
    {
        public RightTriangle(double side, double height)
        {
            Width = side;
            Height = height;
        }

        public override double AreaCalculator()
        {
            return (Width * Height) / 2;
        }

    }
}
