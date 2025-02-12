using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class LearnSkill : IEffect
    {
        private Skill skill;

        public LearnSkill(Skill skill)
        {
            this.skill = skill;
        }

        public void UseEffect(Character caster, List<Character> enemys)
        {
            caster.LearnSkill(skill);
        }
    }
}
