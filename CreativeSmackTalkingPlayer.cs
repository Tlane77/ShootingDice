using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {

        List<String> CreativeSmack = new List<String>
        {
            "Eat A Scooby Snack",
            "Kiss My Biscuits",
            "Lick a Pickle",
            "Build a Wall and Slap it"

        };

        public override void Play(Player other)
        {

            int NewSmackTalk = new Random().Next(0, CreativeSmack.Count);

            // Call roll for "this" object and for the "other" object
            int myRoll = Roll;
            int otherRoll = other.Roll;

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}