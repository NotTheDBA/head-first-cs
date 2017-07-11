using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterFightBehaviors
{
    class Troll : Character
    {
        public override void display()
        {
            System.Console.WriteLine("I am a Troll!");
        }

        public Troll()
        {
            this.setWeapon(new AxBehavior());
        }
    }
}
