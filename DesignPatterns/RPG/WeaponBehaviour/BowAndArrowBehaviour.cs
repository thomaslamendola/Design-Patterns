using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.RPG
{
    public class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Fighting with Bow and Arrow");
        }
    }
}
