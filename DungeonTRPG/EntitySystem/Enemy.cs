using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.EntitySystem.Utility;

namespace DungeonTRPG.EntitySystem
{
    internal class Enemy : Character
    {
        public Enemy(string name, int gold, Stat stat, List<int> IndexSkill) : base(name, gold, stat, IndexSkill)
        {

        }
        public Enemy(string name, int gold, Stat stat, List<Skill> skills) : base(name, gold, stat, skills)
        {

        }
        public Enemy(string name, int gold, Stat stat) : base(name, gold, stat)
        {

        }

        public override Character Clone()
        {
            return new Enemy(Name, Gold, Stat, Skills);
        }
    }
}
