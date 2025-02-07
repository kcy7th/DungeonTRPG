using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.Skill
{
    internal class Skill
    {
        public string name { get; }
        public string description { get; }
        public UseableIn useablein { get; }
        public List<IEffect> effects = new List<IEffect>();

        public Skill(string name, string description, UseableIn useablein)
        {
            this.useablein = useablein;
            this.name = name;
            this.description = description;
        }
        public void AddEffect(IEffect effect)
        {
            effects.Add(effect);
        }

        public Skill(string name, string description, UseableIn useablein, List<IEffect> effects)
        {
            this.name = name;
            this.description = description;
            this.useablein = useablein;
            this.effects = effects;
            this.useablein = useablein;
        }
        public void UseSkill(Character character)
        {
            foreach (var skill in effects)
            {
                skill.UseEffect(character);
            }
        }
    }
}
