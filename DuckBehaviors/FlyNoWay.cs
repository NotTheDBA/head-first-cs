using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors
{
    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I can't fly!");
        }
    }
}
