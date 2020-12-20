using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DuckSimulator
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Cannot fly");
        }
    }
}
