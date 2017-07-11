using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFightBehaviors
{
    class King : Character
    {
        public override void display()
        {
            System.Console.WriteLine("I am a King!");
        }

        public King()
        {
            this.setWeapon(new SwordBehavior());
        }
    }
}
