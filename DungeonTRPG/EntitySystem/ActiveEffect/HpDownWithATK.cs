using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpDownWithATK: IEffect
    {
        int amount;
        int modifier;
        int TotalDamage;
        public HpDownWithATK(int amount, int modifier)
        {
            this.amount = amount;
            this.modifier = modifier;
        }

        //amount+(caster의 ATK*modifier)만큼 체력 감소
        //범용적으로 활용 가능(amount=0, modifier=1.5 / amount=10, modifier=0.5...)
        public void UseEffect(Character caster, Character target)
        {
            //TotalDamage = amount + (caster.stat.ATK*modifier);
            //if (target.stat.Hp-TotalDamage<0) //타겟의 체력과 TotalDamage의 차가 0일 경우
            //{
            //    //체력을 0으로 조정
            //    target.stat.Hp = 0;
            //    //이후 값 설정하거나 호출 (isDead, isAlive, battleEnd() 등...)
            //}
            //else
            //{
            //    target.stat.Hp -= TotalDamage;
            //}

            //// 만약 DamageHp같은 게 있다면 위 식 대신 이걸 쓰기
            //target.Stat.DamageHp(TotalDamage);
        }
    }
}
