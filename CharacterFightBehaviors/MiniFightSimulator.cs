using System;

namespace CharacterFightBehaviors
{
    class MiniFightSimulator
    {
        static void Main(string[] args)
        {
            Character king = new King();
            king.display();
            king.fight();
            king.setWeapon(new BowAndArrowBehavior());
            king.fight();
            Console.WriteLine();

            Character queen = new Queen();
            queen.display();
            queen.fight();
            Console.WriteLine();

            Character knight = new Knight();
            knight.display();
            knight.fight();
            Console.WriteLine();

            Character troll = new Troll();
            troll.display();
            troll.fight();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}