using System;

namespace DesignPatterns.DuckSimulator
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
