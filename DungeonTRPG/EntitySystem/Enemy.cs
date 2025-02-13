using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Manager;

namespace DungeonTRPG.EntitySystem
{
    internal class Enemy : Character
    {
        public Enemy(string name, int gold, Stat stat, List<int> IndexSkill) : base(name, gold, stat, IndexSkill)
        {
        }
        public Enemy(string name, int gold, Stat stat) : base(name, gold, stat)
        {

        }

        public override Character Clone()
        {
            return new Enemy(Name, Gold, Stat.Clone(), new List<int>(Skills));
        }
    }
}
