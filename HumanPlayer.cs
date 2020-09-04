using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll
        {
            get
            {

                Console.WriteLine("Enter a Lucky Number");
                int Number = Int32.Parse(Console.ReadLine());

                return Number;

            }
        }
    }
}