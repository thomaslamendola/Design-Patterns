using System;

namespace DesignPatterns.RPG
{
    public class Knight : Character
    {
        public Knight()
        {
            SetWeapon(new BowAndArrowBehaviour());
        }

        public override void Describe()
        {
            Console.WriteLine("This is a Knight");
        }
    }
}
