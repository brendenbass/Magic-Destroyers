using Magic_Destroyers.Enums;
using Magic_Destroyers.Equipment.Armors.Light;
using Magic_Destroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Mage";
        private const int DEFAULT_LEVEL = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_ABILITY_POINTS = 100;

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints)
        {
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Name = name;
            base.ManaPoints = DEFAULT_ABILITY_POINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }
        public int Firewall()
        {
            return base.Weapon.DamagePoints + 10;
        }
        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return Firewall();
        }

        public override int Defend()
        {
            return Meditation();
        }

        public override int SpecialAttack()
        {
            return ArcaneWrath();
        }
    }
}
