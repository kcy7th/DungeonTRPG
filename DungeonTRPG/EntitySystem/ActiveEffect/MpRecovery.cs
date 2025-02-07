using DungeonTRPG.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class MpRecovery
    {

        private int amount;

        public MpRecovery(int amount)
        {
            this.amount = amount;
        }

        public void UseEffect(Character character)
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
