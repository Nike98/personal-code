
/*
 * ############################################################################
 * ############################################################################
 * 
 *          WAP to show Inheritance using Console Application
 * 
 * ############################################################################
 * ############################################################################
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Child Class
            Rectangle rect = new Rectangle();

            // Setting the width and height from the Rectangle class using the setWidth and setHeight method
            // of the Shape calss from the Rectangle class which has inherited the method
            rect.setWidth(8);
            rect.setHeight(5);

            // Printing the output on the Console Screen using the calculation
            // from the getArea method of the Rectangle class
            Console.WriteLine("The Area of the Rectangle = " + rect.getArea());

            Console.ReadLine();
        }
    }

    // Parent Class
    class Shape
    {
        protected int width;
        protected int height;

        public void setWidth(int width)
        {
            this.width = width;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }
    }

    // Derived/Child class Inheriting the Parent Class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
}
