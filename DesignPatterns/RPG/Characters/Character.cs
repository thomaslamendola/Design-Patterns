using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.RPG
{
    public abstract class Character
    {
        IWeaponBehaviour Weapon;

        protected void SetWeapon(IWeaponBehaviour wb)
        {
            Weapon = wb;
        }

        public abstract void Describe();

        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
