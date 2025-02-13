using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class LearnSkill : IEffect
    {
        private int skill;

        public LearnSkill(int skill)
        {
            this.skill = skill;
        }

        public int UseEffect(Character caster, List<Character> enemys)
        {
            caster.LearnSkill(skill);
            return 0;
        }
    }
}
