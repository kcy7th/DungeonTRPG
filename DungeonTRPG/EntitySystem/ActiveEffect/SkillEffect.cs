using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal abstract class SkillEffect : ISkillEffect
    {
        protected int amount { get; }





        public abstract void Invoke(Character character);
    }
}
