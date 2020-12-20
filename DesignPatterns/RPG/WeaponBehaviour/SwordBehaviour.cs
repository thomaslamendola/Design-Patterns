using System;

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
