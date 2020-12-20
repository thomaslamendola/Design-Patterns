using System;
using System.Collections.Generic;
using System.Text;

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
