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
            System.Console.WriteLine();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
            model.display();
            System.Console.WriteLine();

            DuckCall duckCall = new DuckCall();
            duckCall.performQuack();
            duckCall.performFly();
            duckCall.display();
            System.Console.ReadKey();


        }
    }
}
