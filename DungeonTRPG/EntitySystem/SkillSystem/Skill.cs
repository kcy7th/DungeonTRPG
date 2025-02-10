using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.EntitySystem.SkillSystem
{
    internal class Skill
    {
        public string name { get; }
        public string description { get; }
        public List<IEffect> effects = new List<IEffect>();

        public Skill(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void AddEffect(IEffect effect)
        {
            effects.Add(effect);
        }

        public Skill(string name, string description, List<IEffect> effects)
        {
            this.name = name;
            this.description = description;
            this.effects = effects;
        }
        public void UseSkill(Character character1, Character character2)
        {
            foreach (var skill in effects)
            {
                skill.UseEffect(character1, character2);
            }
        }
    }
}
