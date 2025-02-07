using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal abstract class ItemEffect
    {
        protected int Amount { get; }



        public virtual void Invoke()
        {
            throw new NotImplementedException("asdf");
        }
    }
}
