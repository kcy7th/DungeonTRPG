using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class Rampage:IEffect
    {
        private int KillCount;
        private int amount;

        public Rampage (int amount)
        {
            this.amount = amount;
            KillCount = 1; //기본값
        }

        // (1+이 스킬로 적을 처치한 횟수)*amount만큼 target의 체력 감소
        public void UseEffect(Character caster, Character target)
        {
            if (target.Stat.Hp - KillCount * amount < 0) //타겟의 체력과 KillCount*amount의 차가 0일 경우
            {
                target.Stat.SetDamage(KillCount * amount);
                KillCount++;
            }
            else
            {
                target.Stat.SetDamage(KillCount * amount);
            }
        }
    }
}
