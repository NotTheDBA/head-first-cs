using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors  
{
    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I'm flying.");
        }
    }
}
