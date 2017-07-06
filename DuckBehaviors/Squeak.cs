using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors
{
    class Squeak : IQuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Squeak.");
        }
    }
}
