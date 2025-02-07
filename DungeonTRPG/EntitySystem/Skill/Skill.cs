using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.Skill
{
    internal abstract class EffectSystem : ISkill
    {
        protected string name { get; }
        protected string description { get; }
        public  EffectSystem(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public virtual void UseSkill(Character character)
        {
            Debug.Print("스킬 시전이 할당되지 않았음");
        }
    }
}
