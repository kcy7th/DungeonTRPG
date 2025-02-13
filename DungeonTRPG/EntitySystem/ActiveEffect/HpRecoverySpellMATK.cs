using DungeonTRPG.EntitySystem;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpRecoverySpellMATK: IEffect
    {
        private float healpercent;

        public HpRecoverySpellMATK(float healpercent)
        {
            this.healpercent = healpercent;
        }

        //시전자의 Hp를 amount + 시전자의 주문력의 50% 만큼 회복시키는 효과
        //character 하나만을 갖고 작동하는 기능이지만, 상속된 기능이라 더미 캐릭터 하나를 추가해야만 함
        public int UseEffect(Character caster, List<Character> enemys)
        {
            caster.Heal((int)(caster.Stat.SpellAtk / healpercent));
            return 0;
        }
    }
}
