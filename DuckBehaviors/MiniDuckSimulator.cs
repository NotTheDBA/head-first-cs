using System;
using System.Collections.Generic;
using System.Text;

namespace DuckBehaviors
{
    class MiniDuckSimulator
    {
        public static void Main(String[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
            mallard.display();
            System.Console.ReadKey();
        }
    }
}
