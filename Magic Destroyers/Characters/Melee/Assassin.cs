using Magic_Destroyers.Enums;
using Magic_Destroyers.Equipment.Armors.Leather;
using Magic_Destroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private const string DEFAULT_NAME = "Jimbob";
        private const int DEFAULT_LEVEL = 10;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public LightLeatherVest BodyArmor
        {
            get { return bodyArmor; }
            private set { bodyArmor = value; }
        }
        public Sword Weapon
        {
            get { return weapon; }
            private set { weapon = value; }
        }

        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Assassin(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Assassin(string name, int level, int healthPoints)
        {
            HealthPoints = healthPoints;
            Level = level;
            Name = name;
            AbilityPoints = DEFAULT_ABILITY_POINTS;
            Faction = DEFAULT_FACTION;
            BodyArmor = DEFAULT_BODY_ARMOR;
            Weapon = DEFAULT_WEAPON;
        }

        public void Raze()
        {

        }
        public void BleedToDeath()
        {

        }
        public void Survival()
        {

        }
    }
}
