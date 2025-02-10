using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class StunningBlow: IEffect
    {
        private int amount;

        public StunningBlow(int amount)
        {
            this.amount = amount;
        }

        public void UseEffect(Character player, Character enemy)
        {
            // 플레이어의 스탯에 따라 확률이 조정되는 스턴을 부여할 확률 필드 선언
            // 이 경우, amount는 0.1~0.2로 넣어줄 것
            Random roll = new Random();
            int chance = (int)(roll.Next(1, 10) + player.Stat.Atk * amount);
            // enemy에게 player의 힘*0.75만큼의 피해를 주고
            enemy.Stat.TakeDamage((int)(player.Stat.Atk * 0.75));

            //if (chance > 5)
            //{
            //    enemy.State = State.stun;
            //    //필요하다면, 성공 메세지 호출하기
            //}
            //else
            //{
            //    //필요하다면, 실패 메세지 호출하기
            //}
        }
    }
}
