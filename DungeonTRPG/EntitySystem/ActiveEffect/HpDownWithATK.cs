using DungeonTRPG.Entity;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpDownWithATK: IEffect
    {
        int amount;
        float modifier;
        int TotalDamage;
        public HpDownWithATK(int amount, float modifier)
        {
            this.amount = amount;
            this.modifier = modifier;
        }

        //amount+(caster의 ATK*modifier)만큼 체력 감소
        //범용적으로 활용 가능(amount=0, modifier=1.5 / amount=10, modifier=0.5...)
        public void UseEffect(Character caster, Character target)
        {
            TotalDamage = (int)(amount + (caster.Stat.Atk*modifier));
            target.Damaged(TotalDamage);
        }
    }
}
