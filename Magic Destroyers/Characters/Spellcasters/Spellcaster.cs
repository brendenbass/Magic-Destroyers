using Magic_Destroyers.Enums;

namespace Magic_Destroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        protected const Faction DEFAULT_FACTION = Faction.Spellcasters;

        private int manaPoints;
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;

        public int ManaPoints
        {
            get
            {
                return manaPoints;
            }
            set
            {
                manaPoints = 100;
            }
        }
    }
}
