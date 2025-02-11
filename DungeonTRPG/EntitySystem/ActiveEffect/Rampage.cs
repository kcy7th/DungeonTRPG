using DungeonTRPG.Entity;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class Rampage:IEffect
    {
        public int KillCount;
        private int amount;

        public Rampage (int amount)
        {
            this.amount = amount;
            KillCount = 1; //기본값
        }

        // (1+이 스킬로 적을 처치한 횟수)*amount만큼 target의 체력 감소
        // (int)(amount*(1+0.2*KillCount)) 만큼 target의 체력 감소
        public void UseEffect(Character caster, Character target)
        {
            if (target.Stat.Hp - amount * (1 + 0.2 * KillCount) < 0) //타겟의 체력과 공격력의 차가 0일 경우
            {
                target.Damaged((int)(amount * (1 + 0.2 * KillCount)));
                KillCount++;
            }
            else
            {
                target.Damaged((int)(amount * (1 + 0.2 * KillCount)));
            }
        }
    }
}
