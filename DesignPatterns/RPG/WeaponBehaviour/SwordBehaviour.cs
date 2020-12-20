using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.RPG
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Fighting with Sword");
        }
    }
}
