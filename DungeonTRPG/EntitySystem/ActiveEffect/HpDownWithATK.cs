using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpDownWithATK: IEffect
    {
        int amount;
        int modifier;
        int TotalDamage;
        public HpDownWithATK(int amount, int modifier)
        {
            this.amount = amount;
            this.modifier = modifier;
        }

        //amount+(caster의 ATK*modifier)만큼 체력 감소
        //범용적으로 활용 가능(amount=0, modifier=1.5 / amount=10, modifier=0.5...)
        public void UseEffect(Character caster, Character target)
        {
            TotalDamage = amount + (caster.Stat.Atk*modifier);
            target.Stat.SetDamage(amount);
        }
    }
}
