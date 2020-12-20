using System;

namespace DesignPatterns.DuckSimulator
{
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
