using DungeonTRPG.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpRecovery : Effect
    {
        //상속받은 Amount 값 생성
        public HpRecovery(int amount) : base(amount)
        {
        }

        public override void Invoke(Character character)
        {
            //Character.Health+=Amount;
        }
    }
}
