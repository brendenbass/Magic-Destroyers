using Magic_Destroyers.Enums;
using Magic_Destroyers.Equipment.Armors.Leather;
using Magic_Destroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Jimbob";
        private const int DEFAULT_LEVEL = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_ABILITY_POINTS = 100;

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private LightLeatherVest bodyArmor;
        private Staff weapon;

        public LightLeatherVest BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            private set
            {
                bodyArmor = value;
            }
        }

        public Staff Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }


        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Druid(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Druid(string name, int level, int healthPoints)
        {
            HealthPoints = healthPoints;
            Level = level;
            Name = name;
            ManaPoints = DEFAULT_ABILITY_POINTS;
            Faction = DEFAULT_FACTION;
            BodyArmor = DEFAULT_BODY_ARMOR;
            Weapon = DEFAULT_WEAPON;
        }

        public void Moonfire()
        {

        }
        public void Starburst()
        {

        }
        public void OneWithTheNature()
        {

        }
    }
}
