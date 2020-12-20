using System;

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
