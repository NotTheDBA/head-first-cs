using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors
{
    public class DuckCall
    {
        IQuackBehavior fakeQuack = new FakeQuack();
        IFlyBehavior flyBehavior = new FlyNoWay();

        public void performQuack()
        {
            fakeQuack.quack();
        }

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void display()
        {
            System.Console.WriteLine("I'm a Duck Call.  I only sound like a duck.");
        }
    }

}
