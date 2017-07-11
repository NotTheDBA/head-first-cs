using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFightBehaviors
{
    class KnifeBehavior :IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("I stab with my Knife!");
        }
    }
}
