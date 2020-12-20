using System;

namespace DesignPatterns.DuckSimulator
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehaviour = new Quack();
            FlyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
