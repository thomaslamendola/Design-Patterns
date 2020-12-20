using System;

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
