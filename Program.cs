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
        }
    }
}
