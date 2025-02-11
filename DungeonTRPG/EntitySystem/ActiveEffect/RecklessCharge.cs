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
        //자해 기능을 HpDownSelf로 이전하고, 비슷한 기능을 하지만 매개변수에 비례한 자해 데미지를 주는 효과 HpDownBackfire도 추가했습니다.
        //할당된 아이템들의 효과가 변경되면 삭제
        public void UseEffect(Character caster, Character enemy)
        {
            caster.Damaged(2);
            enemy.Damaged((int)(amount + caster.Stat.Atk * 1));
        }
    }
}
