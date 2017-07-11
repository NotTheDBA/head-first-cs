using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFightBehaviors
{
    public abstract class Character
    {
        public IWeaponBehavior weaponBehavior;

        public Character()
        { }

        public abstract void display();

        public void fight()
        {
            weaponBehavior.useWeapon();
        }

        public void setWeapon(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }
    }
}
