using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Utility.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonTRPG.Entity
{

    internal abstract class Character
    {
        public Stat stat;
        public State state;
        //public Skill skill;
        public string Name { get; }
        public int Gold { get; set; }

        int finalDamage;

        public Character(string name, int gold, Stat stat, State state)
        {
            this.stat = stat;
            this.state = state;
            Name = name;
            Gold = gold;
        }

        // 공격
        public void Attack(Character attacker)
        {
            Console.WriteLine($"{attacker.Name} 공격!");
            Console.WriteLine($"{ attacker.Name }이(가) { this.Name }에게 { finalDamage }의 피해를 입혔습니다!.");
        }

        // 피격
        public void Damaged(Character attacker)  // Attack() 메서드를 호출한 Character를 attacker에 전달
        {
            finalDamage = attacker.stat.Atk - this.stat.Def; // 공격자의 공격력과 피격자의 방어력을 계산하여 데미지 계산
            this.stat.CurHp -= finalDamage;

            this.stat.CurMp = Math.Max(this.stat.CurHp, 0); // 체력이 음수가 되지 않도록 설정

            if (this.stat.CurHp <= 0)
            {
                Die();
            }
            else
            {
                // 살았을 경우 행동
            }
        }

        // 죽음 (호출한 캐릭터가 플레이어인지 적인지 파악 필요)
        public void Die()
        {
            // 플레이어가 죽었을 경우

            // 적이 죽었을 경우
        }

        // 스킬
        public void skill(Character attacker)
        {
            Console.WriteLine($"{attacker.Name} 스킬 사용!");
            Console.WriteLine($"{ attacker.Name }이(가) { this.Name }에게 스킬로 { finalDamage }의 피해를 입혔습니다!.");
        }

        // 상태이상
        public void Debuff()
        {

        }

    }
}
