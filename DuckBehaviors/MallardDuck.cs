using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors
{
    public class MallardDuck : Duck , IQuackBehavior, IFlyBehavior
    {
        public MallardDuck()
        {
            this.flyBehavior = new FlyWithWings();
            this.quackBehavior = new Quack();
        }

        public void quack()
        {
            this.performQuack();
        }

        public void fly()
        {
            this.performFly();
        }

        override public void display()
        {
            System.Console.WriteLine("I'm a real Mallard Duck!");
        }
    }
}
