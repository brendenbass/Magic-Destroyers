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
            Character warrior = new Warrior();
            Character knight = new Knight();
            Character assassin = new Assassin();
            Character mage = new Mage();
            Character necromancer = new Necromancer();
            Character druid = new Druid();

            List<Character> meleeTeam = new List<Character>();
            List<Character> spellTeam = new List<Character>();

            meleeTeam.Add(warrior);
            meleeTeam.Add(knight);
            meleeTeam.Add(assassin);
            spellTeam.Add(mage);
            spellTeam.Add(necromancer);
            spellTeam.Add(druid);
        }
    }
}
