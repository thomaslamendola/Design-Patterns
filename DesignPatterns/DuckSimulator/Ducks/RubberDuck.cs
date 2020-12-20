using System;

namespace DesignPatterns.DuckSimulator
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck!");
        }
    }
}
