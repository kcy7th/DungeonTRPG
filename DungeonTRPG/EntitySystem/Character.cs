using DungeonTRPG.Entity.Utility;

namespace DungeonTRPG.Entity
{
    internal abstract class Character
    {
        protected string name;
        protected EntityStat stat;
        protected int currentGold;
        protected Inventory inventory;
    }
}
