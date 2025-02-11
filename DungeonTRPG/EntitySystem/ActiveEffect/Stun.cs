using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class Stun : IEffect
    {
        //대상을 기절시키는 효과, 확률=50%
        public void UseEffect(Character player, Character enemy)
        {
            Random roll = new Random();
            int chance = (int)(roll.Next(1, 10));

            if (chance > 5)
            {
                enemy.CharacterState.SetState(State.Stun);
                //필요하다면, 성공 메세지 호출하기
            }
            else
            {
                //필요하다면, 실패 메세지 호출하기
            }
        }
    }
}
