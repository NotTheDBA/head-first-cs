using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFightBehaviors
{
    class AxBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("I throw my Axe!");
        }
    }
}
