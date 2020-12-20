using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.RPG
{
    public class Queen : Character
    {
        public Queen()
        {
            SetWeapon(new KnifeBehaviour());
        }

        public override void Describe()
        {
            Console.WriteLine("This is a Queen");
        }
    }
}
