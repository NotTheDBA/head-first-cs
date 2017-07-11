using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors
{
    class FlyRocketPowered : IFlyBehavior 
    {
        public void fly()
        {
            System.Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
