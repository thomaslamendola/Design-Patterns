using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DuckSimulator
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
}
