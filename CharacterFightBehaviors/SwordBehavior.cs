using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFightBehaviors
{
    class SwordBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("I swing my Sword!");
        }
    }
}
