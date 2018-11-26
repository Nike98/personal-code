using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rectangle_Square_Triangle_Shape_Area_OOP
{
    abstract class Shape
    {
        public abstract double CalcArea();
    }

    class Square: Shape
    {
        private double side;

        // Constructor of the Class Square to take the inputs
        public Square(double side) => this.side = side;

        public override double CalcArea() => side * side;
    }

    class Rectangle : Shape
    {
        private double length, breadth;

        // Constructor of the Class Rectangle to take the inputs
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override double CalcArea() => length * breadth;
    }

    class Triangle : Shape
    {
        private double breadth, height;

        // Constructor of the Class Triangle to take the inputs
        public Triangle(double breadth, double height)
        {
            this.breadth = breadth;
            this.height = height;
        }

        public override double CalcArea() => 0.5 * breadth * height;
    }
}