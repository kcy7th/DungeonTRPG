using DungeonTRPG.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Interface
{
    //아이템 효과가 상속할 효과 인터페이스
    internal interface IActiveEffect
    {

        void Invoke(Character character);
    }
}
