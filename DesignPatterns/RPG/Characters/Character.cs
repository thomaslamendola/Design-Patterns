namespace DesignPatterns.RPG
{
    public abstract class Character
    {
        IWeaponBehaviour Weapon;

        public void SetWeapon(IWeaponBehaviour wb)
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
