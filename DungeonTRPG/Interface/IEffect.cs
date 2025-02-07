using DungeonTRPG.Entity;
using DungeonTRPG.Entity.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Interface
{
    //스킬 효과가 상속할 스킬 인터페이스
    internal interface IEffect
    {
        void UseEffect(Character player, Character enemy);
    }
}
