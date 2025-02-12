using DungeonTRPG.Entity.Utility;

namespace DungeonTRPG.Entity.Enemy
{
    internal class Enemy : Character
    {
        public Enemy(string name, int gold, Stat stat, List<int> IndexSkill) : base(name, gold, stat,IndexSkill)
        {

        }
        public Enemy(string name, int gold, Stat stat) : base(name, gold, stat)
        {

        }
    }
}
