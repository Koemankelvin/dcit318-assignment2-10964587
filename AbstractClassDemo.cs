using System;

namespace OOPDemo
{
    public abstract class Shape  // Abstract class
    {
        public abstract double GetArea();  // Abstract method
    }

    public class Circle : Shape  // Derived class
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()  // Implementing the abstract method
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape  // Another derived class
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()  // Implementing the abstract method
        {
            return Width * Height;
        }
    }
}
