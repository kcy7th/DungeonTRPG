using DungeonTRPG.Entity;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpDown: IEffect
    {
        int amount;
        
        public HpDown(int amount)
        {
            this.amount = amount;
        }

        //Hp가 amount만큼 줄어드는 효과 클래스
        //amount를 방어력만큼 설정해서 caster의 방어력만큼 target의 체력을 깎는 것도 생각해볼 수 있을 것 같습니다

        public void UseEffect(Character caster, Character target)
        {
            target.Stat.TakeDamage(amount);
        }
    }
}
