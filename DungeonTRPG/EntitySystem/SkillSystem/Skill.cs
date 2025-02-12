using DungeonTRPG.Entity;
using DungeonTRPG.EntitySystem.ActiveEffect;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.EntitySystem.SkillSystem
{
    internal class Skill
    {
        public string name { get; }
        public string description { get; }
        public List<IEffect> effects = new List<IEffect>();
        public int cost;
        public Skill(string name, string description, int cost)
        {
            this.name = name;
            this.description = description;
            this.cost = cost;
        }

        public void AddEffect(IEffect effect)
        {
            effects.Add(effect);
        }

        public Skill(string name, string description, List<IEffect> effects, int cost)
        {
            this.name = name;
            this.description = description;
            this.effects = effects;
        }
        public bool UseSkill(Character caster, Character target)
        {
            if (caster.Stat.Mp >= cost)
            {
                foreach (var skill in effects)
                {
                    skill.UseEffect(caster, target);
                    caster.UseMana(cost);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
