using DungeonTRPG.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpRecovery
    {

        private int amount;

        public HpRecovery(int amount)
        {
            this.amount = amount;
        }

        public void UseEffect(Character character)
        {
            //// 예외처리가 포함된 채 체력 회복시키기
            //if (character.stat.Hp+=amount > character.stat.MaxHp)
            //{
            //    character.stat.Hp = character.stat.MaxHp;
            //}
            //else
            //{
            //    character.stat.Hp += amount;
            //}

            //// 만약 AddHp같은 게 있다면 위 식 대신 이걸 쓰기
            //character.Stat.AddHp(amount);
            ////체력 증가 함수 쓰기    
        }
    }
}
