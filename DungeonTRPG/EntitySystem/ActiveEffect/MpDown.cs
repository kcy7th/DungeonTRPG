using DungeonTRPG.EntitySystem;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class MpDown:IEffect
    {

        private int amount;

        public MpDown(int amount)
        {
            this.amount = amount;
        }

        //시전자의 Mp를 amount만큼 감소시키는 효과
        //character 하나만을 갖고 작동하는 기능이지만, 상속된 기능이라 더미 캐릭터 하나를 추가해야만 함
        public int UseEffect(Character caster, List<Character> enemys)
        {
            caster.UseMana(amount);
            return 0;
        }
    }
}
