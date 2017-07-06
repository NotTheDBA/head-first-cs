using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors
{
    class Quack : IQuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Quack.");
        }

    }
}
