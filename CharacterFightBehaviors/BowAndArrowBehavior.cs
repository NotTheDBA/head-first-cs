using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFightBehaviors
{
    class BowAndArrowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            System.Console.WriteLine("I shoot my Bow and Arrow.");
        }
    }
}
