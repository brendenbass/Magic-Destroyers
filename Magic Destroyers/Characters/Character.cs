using Magic_Destroyers.Characters.Interfaces;
using Magic_Destroyers.Enums;
using Magic_Destroyers.Equipment.Armors;
using Magic_Destroyers.Equipment.Weapons;
using System;

namespace Magic_Destroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Faction faction;
        private int healthPoints;
        private int level;
        private int scores;
        private string name;
        private bool isAlive;

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

        private Armor bodyArmor;
        private Weapon weapon;

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

        public int Scores
        {
            get
            {
                return scores;
            }
            protected set
            {
                scores = value;
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

        public Armor BodyArmor {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }

        }
        public Weapon Weapon
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

        public bool IsAlive {
            get
            {
                return isAlive;
            }
            protected set
            {
                isAlive = value;
            }
        }

        public abstract int Attack();

        public abstract int Defend();

        public abstract int SpecialAttack();

        public void TakeDamage(int damage, string attackerName)
        {
            if(Defend() < damage)
            {
                healthPoints = healthPoints - damage + Defend();

                if(healthPoints <= 0)
                {
                    isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha, your damage was not enough to harm me!");
            }

            if (!isAlive)
            {
                Console.WriteLine($"{name} received {damage} damage from {attackerName}, and is now dead.");
            }
            else
            {
                Console.WriteLine($"{name} received {damage} damage from {attackerName}, and now has {healthPoints} health.");
            }
        }

        public void WonBattle()
        {
            scores++;

            if (scores % 10 == 0)
            {
                level++;
            }
        }
    }
}
