using DungeonTRPG.EntitySystem;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class StunningBlow: IEffect
    {
        private int amount;

        public StunningBlow(int amount)
        {
            this.amount = amount;
        }

        //아이템 "번개의 돌" 에 사용되고 있어 일단은 남겨둔 효과입니다.
        //아이템 효과가 변경될 경우 이 스킬 삭제
        public int UseEffect(Character caster, List<Character> enemys)
        {
            // 플레이어의 스탯에 따라 확률이 조정되는 스턴을 부여할 확률 필드 선언
            // 이 경우, amount는 0.1~0.2로 넣어줄 것
            Random roll = new Random();
            int chance = (int)(roll.Next(1, 10) + caster.Stat.Atk * amount);
            // enemy에게 player의 힘*0.75만큼의 피해를 주고
            int damage = enemys[0].Damaged((int)(caster.Stat.Atk * 0.75));

            if (chance > 5)
            {
                enemys[0].CharacterState.SetState(State.Stun);
                //필요하다면, 성공 메세지 호출하기
            }
            else
            {
                //필요하다면, 실패 메세지 호출하기
            }

            return damage;
        }
    }
}
