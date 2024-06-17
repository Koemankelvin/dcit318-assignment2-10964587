using System;

namespace OOPDemo
{
    public class Animal  // Base class
    {
        public virtual void MakeSound()  // Virtual method
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal  // Derived class
    {
        public override void MakeSound()  // Override method
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal  // Another derived class
    {
        public override void MakeSound()  // Override method
        {
            Console.WriteLine("Meow");
        }
    }
}
