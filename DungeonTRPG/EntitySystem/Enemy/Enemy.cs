using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity.Enemy
{
    internal class Enemy : Character
    {
        public Enemy(string name, int gold, Stat stat) : base(name, gold, stat)
        {

        }
    }
}
