using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpRecovery: IEffect
    {
        private int amount;

        public HpRecovery(int amount)
        {
            this.amount = amount;
        }

        //character 하나만을 갖고 작동하는 기능이지만, 상속된 기능이라 더미 캐릭터 하나를 추가해야만 함
        //character 자리에 enemy를 넣고 amount 자리에 -(player.Stat.Atk*1.25)같은 값을 넣어서 회복 대신 플레이어의 공격력에 비례한 강한 피해를 가하는 공격 스킬로 재사용 가능

        public void UseEffect(Character character, Character placeholder)
        {
            //// 예외처리가 포함된, amount만큼 체력 회복시키기
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
        }
    }
}
