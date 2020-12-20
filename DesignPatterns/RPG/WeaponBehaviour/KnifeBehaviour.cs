using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.RPG
{
    public class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Fighting with Knife");
        }
    }
}
