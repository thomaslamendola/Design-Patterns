using System;
using System.Collections.Generic;
using System.Text;

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
