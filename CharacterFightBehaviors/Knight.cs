using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFightBehaviors
{
    class Knight : Character
    {
        public override void display()
        {
            System.Console.WriteLine("I am a Knight!");
        }

        public Knight()
        {
            this.setWeapon(new KnifeBehavior());
        }
    }
}
