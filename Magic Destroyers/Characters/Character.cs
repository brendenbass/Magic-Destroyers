using Magic_Destroyers.Characters.Interfaces;
using Magic_Destroyers.Enums;
using System;

namespace Magic_Destroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;

        public Faction Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;
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

        public abstract void Attack();

        public abstract void Defend();

        public abstract void SpecialAttack();
    }
}
