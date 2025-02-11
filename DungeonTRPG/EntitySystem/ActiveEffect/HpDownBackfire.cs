using DungeonTRPG.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpDownBackfire
    {

        private int amount;

        public HpDownBackfire(int amount)
        {
            this.amount = amount;
        }

        //대상에게 amount만큼 피해를 입히고, 시전자에게 피해의 10%만큼의 데미지를 가하는 효과
        public void UseEffect(Character caster, Character enemy)
        {
            caster.Damaged((int)(amount * 0.1));
            enemy.Damaged(amount);
        }
    }
}
