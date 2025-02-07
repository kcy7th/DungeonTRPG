using DungeonTRPG.Entity;
using DungeonTRPG.Entity.Player;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class RecklessCharge: IEffect
    {

        private int amount;

        public RecklessCharge(int amount)
        {
            this.amount = amount;
        }

        public void UseEffect(Character player, Character enemy)
        {
            //// 플레이어의 체력을 고정적으로 2 깎고
            //player.Stat.hp -= 2;
            //// amount+플레이어의 힘*0.2만큼 피해를 가하기
            //enemy.Stat.hp -= amount + player.Stat.str * 0.2;

            //// 만약 AddHp같은 게 있다면 위 식 대신 이걸 쓰기
            //player.AddHp(-2);
            //enemy.AddHp(-amount + player.Stat.str * 0.2);
        }
    }
}
