using System;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance and Method Overriding
            Animal animal = new Animal();
            animal.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();

            // Abstract Classes and Methods
            Shape circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.GetArea()}");

            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        }
    }
}
