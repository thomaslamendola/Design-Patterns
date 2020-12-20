using System;

namespace DesignPatterns.DuckSimulator
{
    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
