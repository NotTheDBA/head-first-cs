using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors
{
    class FakeQuack : IQuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Fake quack.  Sounds real.");
        }

    }
}
