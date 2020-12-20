using System;

namespace DesignPatterns.RPG
{
    public class Troll : Character
    {
        public Troll()
        {
            SetWeapon(new AxeBehaviour());
        }

        public override void Describe()
        {
            Console.WriteLine("This is a Troll");
        }
    }
}
