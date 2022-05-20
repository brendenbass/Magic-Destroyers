using Magic_Destroyers.Armors;
using Magic_Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public class Necromancer
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;

        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                abilityPoints = 100;
            }
        }

        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = "Spellcasters";
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length <= 2 || value.Length >= 21)
                {
                    throw new ArgumentOutOfRangeException(String.Empty, $"The {this.GetType().Name}'s name length must be between 3 - 20 characters.");
                }
                else
                {
                    name = value;
                }
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = 1;
            }
        }

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                healthPoints = 100;
            }
        }

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

        public Sword Weapon
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

        public Necromancer()
            :this ("Unnamed Necromancer", 10)
        {
        }

        public Necromancer(string name, int level)
            :this (name, level, 100)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
            BodyArmor = new LightLeatherVest();
            Weapon = new Sword();
        }

        public void ShadowRage()
        {

        }
        public void VampireTouch()
        {

        }
        public void BoneShield()
        {

        }
    }
}
