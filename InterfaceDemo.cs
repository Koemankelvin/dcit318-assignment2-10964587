using System;

namespace OOPDemo
{
    public interface IMovable  // Interface definition
    {
        void Move();
    }

    public class Car : IMovable  // Class implementing the interface
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable  // Another class implementing the interface
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
