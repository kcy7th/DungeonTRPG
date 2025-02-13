using DungeonTRPG.EntitySystem;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class RecklessCharge: IEffect
    {

        private int amount;

        public RecklessCharge(int amount)
        {
            this.amount = amount;
        }

        //아이템 "화염병", "폭탄" 에 사용되고 있어 일단은 남겨둔 스킬 이펙트
        //할당된 아이템들의 효과가 변경되면 삭제
        public int UseEffect(Character caster, List<Character> enemys)
        {
            caster.Damaged(2);
            return enemys[0].Damaged((int)(amount + caster.Stat.Atk * 1));
        }
    }
}
