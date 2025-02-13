using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem.ActiveEffect;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;
using System.Diagnostics.SymbolStore;

namespace DungeonTRPG.EntitySystem.SkillSystem
{
    internal class Skill
    {
        public string name { get; }
        public string description { get; }
        public List<IEffect> effects = new List<IEffect>();
        public bool isSplash = false;
        public int cost;
        public Skill(string name, string description, int cost, bool isSplash)
        {
            this.name = name;
            this.description = description;
            this.cost = cost;
            this.isSplash = isSplash;
        }
        public Skill(string name, string description, List<IEffect> effects, int cost, bool isSplash)
        {
            this.name = name;
            this.description = description;
            this.effects = effects;
            this.cost = cost;
            this.isSplash = isSplash;
        }

        public Skill Clone()
        {
            return new Skill(name, description, effects, cost, isSplash);
        }

        public void AddEffect(IEffect effect)
        {
            effects.Add(effect);
        }
        
        public int UseSkill(Character caster, List<Character> targets)
        {
            int damage = 0;

            if (caster.Stat.Mp >= cost)
            {
                foreach (var skill in effects)
                {
                    damage += skill.UseEffect(caster, targets);
                    caster.UseMana(cost);
                }
            }
            return damage;
        }
    }
}
