using System;

namespace DesignPatterns.RPG
{
    public class AxeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Fighting with Axe");
        }
    }
}
