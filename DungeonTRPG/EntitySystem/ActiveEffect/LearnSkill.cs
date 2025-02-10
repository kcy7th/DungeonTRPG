using DungeonTRPG.Entity;
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

        public void UseEffect(Character player, Character target)
        {
            player.LearnSkill(skill);
        }
    }
}
