using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFightBehaviors
{
    class Queen : Character
    {
        public override void display()
        {
            System.Console.WriteLine("I am a Queen!");
        }

        public Queen()
        {
            this.setWeapon(new BowAndArrowBehavior());
        }
    }
}
