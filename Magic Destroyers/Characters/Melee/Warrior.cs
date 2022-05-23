using Magic_Destroyers.Enums;
using Magic_Destroyers.Equipment.Armors.Heavy;
using Magic_Destroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private const string DEFAULT_NAME = "Jimbob";
        private const int DEFAULT_LEVEL = 10;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        public Warrior()
            :this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level)
            :this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Name = name;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public void Strike()
        {

        }
        public void Execute()
        {

        }
        public void SkinHarden()
        {

        }

        public override void Attack()
        {
            Strike();
        }

        public override void Defend()
        {
            SkinHarden();
        }

        public override void SpecialAttack()
        {
            Execute();
        }
    }
}
