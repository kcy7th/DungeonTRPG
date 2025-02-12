using DungeonTRPG.Entity;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpRecoverySpellATk: IEffect
    {
        private int amount;

        public HpRecoverySpellATk(int amount)
        {
            this.amount = amount;
        }

        //시전자의 Hp를 amount + 시전자의 주문력의 50% 만큼 회복시키는 효과
        //character 하나만을 갖고 작동하는 기능이지만, 상속된 기능이라 더미 캐릭터 하나를 추가해야만 함
        public void UseEffect(Character caster, Character placeholder)
        {
            caster.Heal(amount+(int)(caster.Stat.SpellAtk / 0.5f)); 
        }
    }
}
