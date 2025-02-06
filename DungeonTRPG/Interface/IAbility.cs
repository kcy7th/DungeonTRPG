using DungeonTRPG.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Interface
{
    internal interface IAbility
    {
        void Invoke(Character character);
    }
}
