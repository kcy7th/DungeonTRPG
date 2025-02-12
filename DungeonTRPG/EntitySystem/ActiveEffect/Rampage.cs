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

        // 대상의 HP를 (1+이 스킬로 적을 처치한 횟수)*amount만큼 감소시키는 효과
        // 처치 시, 킬카운트++
        public void UseEffect(Character caster, List<Character> targets)
        {
            if ((targets[0].Stat.Hp - amount * (1 + 0.2 * KillCount)) + targets[0].Stat.Def < 0) //타겟이 이 공격을 받은 뒤의 체력이 0보다 낮을 경우
            {
                targets[0].Damaged((int)(amount * (1 + 0.2 * KillCount)));
                KillCount++;
            }
            else
            {
                targets[0].Damaged((int)(amount * (1 + 0.2 * KillCount)));
            }
        }
    }
}
