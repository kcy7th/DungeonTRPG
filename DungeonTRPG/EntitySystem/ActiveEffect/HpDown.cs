using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpDown: IEffect
    {
        int amount;
        
        public HpDown(int amount)
        {
            this.amount = amount;
        }

        //Hp가 amount만큼 줄어드는 효과 클래스
        //amount를 방어력만큼 설정해서 caster의 방어력만큼 target의 체력을 깎는 것도 생각해볼 수 있을 것 같습니다

        public void UseEffect(Character caster, Character target)
        {
            //if (target.stat.Hp-amount<0) //타겟의 체력과 amount의 차가 0일 경우
            //{
            //    //체력을 0으로 조정
            //    target.stat.Hp = 0;
            //    //이후 값 설정하거나 호출 (isDead, isAlive, battleEnd() 등...)
            //}
            //else
            //{
            //    target.stat.Hp -= amount;
            //}

            //// 만약 DamageHp같은 게 있다면 위 식 대신 이걸 쓰기
            //target.Stat.DamageHp(amount);
        }
    }
}
