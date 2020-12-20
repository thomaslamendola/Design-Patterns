using System;

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
