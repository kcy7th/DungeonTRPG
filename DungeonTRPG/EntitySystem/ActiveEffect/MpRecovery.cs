using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class MpRecovery: IEffect
    {

        private int amount;

        public MpRecovery(int amount)
        {
            this.amount = amount;
        }

        //character 하나만을 갖고 작동하는 기능이지만, 상속된 기능이라 더미 캐릭터 하나를 추가해야만 함
        public void UseEffect(Character character, Character placeholder)
        {
            //// 예외처리가 포함된 채 마나 회복시키기
            //if (character.stat.Mp+=amount > character.stat.MaxMp)
            //{
            //    character.stat.Mp = character.stat.MaxMp;
            //}
            //else
            //{
            //    character.stat.Mp += amount;
            //}

            //// 만약 AddMp같은 게 있다면 위 식 대신 이걸 쓰기
            //character.Stat.AddMp(amount);
        }
    }
}
