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

        //character 하나만을 갖고 작동하는 기능이지만, 상속된 기능이라 더미 캐릭터 하나를 추가해야만 함
        //character 자리에 enemy를 넣고 amount 자리에 -(player.Stat.Atk*1.25)같은 값을 넣어서 회복 대신 플레이어의 공격력에 비례한 강한 피해를 가하는 공격 스킬로 재사용 가능
        //생각해보니 쓸 수가 없네요. 조건문때문에 데미지+현재 체력이 최대 체력보다 높으면 최대 체력으로 세팅을 해버려서

        public void UseEffect(Character caster, Character placeholder)
        {
            caster.Heal(amount); //현재 체력+회복량만큼의 체력으로 조정
        }
    }
}
