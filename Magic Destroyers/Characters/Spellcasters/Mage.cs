using Magic_Destroyers.Armors;
using Magic_Destroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public class Mage
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;

        private ClothRobe bodyArmor;
        private Staff weapon;

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


        public Mage()
        {

        }

        public void ArcaneWrath()
        {

        }
        public void Firewall()
        {

        }
        public void Meditation()
        {

        }
    }
}
