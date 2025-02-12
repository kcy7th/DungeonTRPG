using DungeonTRPG.EntitySystem;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class StealGold:IEffect
    {
        int amount;
        public StealGold(int amount)
        {
            this.amount = amount;
        }


        //대상의 골드를 갈취하는 효과
        //
        public void UseEffect(Character caster, List<Character> targets)
        {
            bool stolemoney = targets[0].SpendGold(amount); //대상의 골드를 차감시키고

            if (stolemoney) //털었다면
            {
                caster.SpendGold(-amount);//amount의 -만큼 SpendGold (반대로 올리기)
            }
        }
    }
}
