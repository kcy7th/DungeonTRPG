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
            //if (target.stat.Hp-KillCount*amount<0) //타겟의 체력과 KillCount*amount의 차가 0일 경우
            //{
            //    //체력을 0으로 조정
            //    target.stat.Hp = 0;
            //    //그리고 KillCount 1 증가
            //    KillCount++;
            //    //이후 값 설정하거나 호출 (isDead, isAlive, battleEnd() 등...)
            //}
            //else
            //{
            //    target.stat.Hp -= KillCount*amount;
            //}

            //// 만약 DamageHp같은 게 있다면 위 식 대신 이걸 쓰기
            //target.Stat.DamageHp(KillCount*amount);
        }
    }
}
