using DungeonTRPG.Entity;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class HpRecovery: IEffect
    {
        private int amount;

        public HpRecovery(int amount)
        {
            this.amount = amount;
        }

        //시전자의 Hp를 amount만큼 회복시키는 효과
        //character 하나만을 갖고 작동하는 기능이지만, 상속된 기능이라 더미 캐릭터 하나를 추가해야만 함
        public void UseEffect(Character caster, Character placeholder)
        {
            caster.Heal(amount); //현재 체력+회복량만큼의 체력으로 조정
        }
    }
}
