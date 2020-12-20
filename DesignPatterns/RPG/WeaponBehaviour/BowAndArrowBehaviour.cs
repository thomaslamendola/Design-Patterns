using System;

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
