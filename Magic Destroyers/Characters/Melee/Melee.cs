using Magic_Destroyers.Enums;

namespace Magic_Destroyers.Characters.Melee
{
    public class Melee : Character
    {
        protected const Faction DEFAULT_FACTION = Faction.Melee;

        private int abilityPoints;

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
    }
}
