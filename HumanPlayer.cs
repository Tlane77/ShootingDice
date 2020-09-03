using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {

            Console.WriteLine("Enter a Number");
            int Number = Int32.Parse(Console.ReadLine());

            return Number;

            // // Call roll for "this" object and for the "other" object
            // int myRoll = Roll();
            // int otherRoll = other.Roll();

            // Console.WriteLine($"{Name} rolls a {myRoll}");
            // Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            // if (myRoll > otherRoll)
            // {
            //     Console.WriteLine($"{Name} Wins!");
            // }
            // else if (myRoll < otherRoll)
            // {
            //     Console.WriteLine($"{other.Name} Wins!");
            // }
            // else
            // {
            //     // if the rolls are equal it's a tie
            //     Console.WriteLine("It's a tie");
            // }
        }
    }
}