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
            Random rng = new Random();

            int currentMelee = 0;
            int currentSpellCaster = 0;

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
                currentMelee = rng.Next(0, meleeTeam.Count);
                currentSpellCaster = rng.Next(0, spellTeam.Count);

                spellTeam[currentSpellCaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name);

                if (!spellTeam[currentSpellCaster].IsAlive)
                {
                    meleeTeam[currentMelee].WonBattle();
                    spellTeam.Remove(spellTeam[currentSpellCaster]);

                    if(spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!");
                        break;
                    }
                    else
                    {
                        currentSpellCaster = rng.Next(0, spellTeam.Count);
                    }
                }

                meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellCaster].Attack(), spellTeam[currentSpellCaster].Name);

                if (!meleeTeam[currentMelee].IsAlive)
                {
                    spellTeam[currentSpellCaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMelee]);

                    if(meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spell team has won!");
                        break;
                    }
                    else
                    {
                        currentMelee = rng.Next(0, meleeTeam.Count);
                    }
                }
            }
        }
    }
}
