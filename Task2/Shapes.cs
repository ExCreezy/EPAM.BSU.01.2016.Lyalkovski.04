using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   
    public class Rectangle : IShape
    {
        public double Height { get; }
        public double Width { get; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public virtual double GetPerimeter()
        {
            return (Height + Width) * 2;
        }

        public virtual double GetArea()
        {
            return Height * Width;
        }
    }


    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }

        public override double GetArea()
        {
            return Math.Pow(Width, 2);
        }

        public override double GetPerimeter()
        {
            return Width * 2;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; }
        
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : IShape
    {
        public double BaseSide { get; }
        public double Side1 { get; }
        public double Side2 { get; }

        public Triangle(double baseSide, double side1, double side2)
        {
            BaseSide = baseSide;
            Side1 = side1;
            Side2 = side2;
        }

        public double GetPerimeter()
        {
            return BaseSide + Side1 + Side2;
        }

        public double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Pow(halfPerimeter * (halfPerimeter - BaseSide) * (halfPerimeter - Side1) * (halfPerimeter - Side2), 2);
        }
    }


}
