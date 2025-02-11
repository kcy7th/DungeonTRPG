using DungeonTRPG.Entity;
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
        public void UseEffect(Character caster, Character enemy)
        {
            caster.Damaged(2);
            enemy.Damaged((int)(amount + caster.Stat.Atk * 1));
        }
    }
}
