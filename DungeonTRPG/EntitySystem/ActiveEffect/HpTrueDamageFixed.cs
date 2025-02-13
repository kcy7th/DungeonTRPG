using DungeonTRPG.EntitySystem;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpTrueDamageFixed: IEffect
    {
        int amount;
        
        public HpTrueDamageFixed(int amount)
        {
            this.amount = amount;
        }

        //타겟의 Hp가 amount만큼 줄어드는 효과
        public int UseEffect(Character caster, List<Character> enemys)
        {
            return enemys[0].TrueDamaged(amount);
        }
    }
}
