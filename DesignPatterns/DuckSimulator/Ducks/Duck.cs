using System;

namespace DesignPatterns.DuckSimulator
{
    public abstract class Duck
    {
        public IQuackBehaviour QuackBehaviour { get; set; }
        public IFlyBehaviour FlyBehaviour { get; set; }

        public void Swim() 
        {
            Console.WriteLine("Floating...");
        }

        public abstract void Display();

        public void PerformQuack() 
        {
            QuackBehaviour.Quack();
        }

        public void PerformFly() 
        {
            FlyBehaviour.Fly();
        }

        protected void SetQuackBehaviour(IQuackBehaviour qb) 
        {
            QuackBehaviour = qb;
        }

        protected void SetFlyBehaviour(IFlyBehaviour fb)
        {
            FlyBehaviour = fb;
        }
    }
}
