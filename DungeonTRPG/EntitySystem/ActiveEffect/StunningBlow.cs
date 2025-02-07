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
            //// 플레이어의 스탯에 따라 확률이 조정되는 스턴을 부여할 확률 필드 선언
            //// 이 경우, amount는 0.1~0.2로 넣어줄 것
            //Random roll = new Random();
            //int chance = roll.Next(1, 10)+player.Stat.Str*amount;
            //// enemy에게 player의 힘*0.75만큼의 피해를 주고
            //enemy.Stat.hp -= player.Stat.str * 0.75;
            //// 이후 확률에 따른 값 도출
            //if (chance > 5)
            //{
            //    enemy.State = State.stun;
            //    //필요하다면, 성공 메세지 호출하기
            //}
            //else
            //{
            //    //필요하다면, 실패 메세지 호출하기
            //}


            //// 만약 AddHp같은 게 있다면 위 식 대신 이걸 쓰기
            //Random roll = new Random();
            //int chance = roll.Next(1, 10) + player.Stat.Str * amount;

            //enemy.AddHp(-(player.Stat.str * 0.75));
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
