using Magic_Destroyers.Characters;
using Magic_Destroyers.Characters.Melee;
using Magic_Destroyers.Characters.Spellcasters;
using System;
using System.Collections.Generic;

namespace Magic_Destroyers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                //new Knight(),
                //new Assassin(),
                new Mage(),
                new Mage(),
                new Mage(),
                //new Necromancer(),
                //new Druid()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach(var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            while (!gameOver)
            {
                //1. Take a random melee
                //2. Take a random spellcaster

                //3. Melee attacks Spellcaster
                //3.1 Check if the character died and remove him from the team
                //3.2 If dead, get another character from the team

                //4. Spellcaster attacks Melee
                //4.1 Check if the character died and remove him from the team
                //4.2 If dead, get another character from the team

                //5. If no characters are alive from either team, gameOver = true
            }
        }
    }
}
