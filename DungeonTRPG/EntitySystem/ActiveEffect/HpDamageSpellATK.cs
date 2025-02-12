using DungeonTRPG.EntitySystem;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpDamageSpellATK: IEffect
    {
        float modifier;
        int TotalDamage;
        public HpDamageSpellATK(float modifier)
        {
            this.modifier = modifier;
        }

        //타겟의 Hp가 시전자의 마법공격력*설정된 값(modifier)만큼 감소하는 효과
        public void UseEffect(Character caster, List<Character> enemys)
        {
            TotalDamage = (int)(caster.Stat.SpellAtk*modifier);
            enemys[0].Damaged(TotalDamage);
        }
    }
}
