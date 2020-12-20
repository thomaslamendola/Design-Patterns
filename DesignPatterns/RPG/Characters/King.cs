using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.RPG
{
    public class King : Character
    {
        public King()
        {
            SetWeapon(new SwordBehaviour());
        }

        public override void Describe()
        {
            Console.WriteLine("This is a King");
        }
    }
}
