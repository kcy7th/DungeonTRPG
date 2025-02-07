using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity
{

    internal abstract class Character
    {
        public Stat stat;
        public State state;
        //public Skill skill;
        public string Name { get; }
        public int Gold { get; set; }

        public Character(string name, int gold, Stat stat, State state)
        {
            this.stat = stat;
            this.state = state;
            Name = name;
            Gold = gold;
        }

        // 공격
        public void Attack()
        {

        }

        // 피격
        public void Damaged()
        {

        }

        // 죽음
        public void Die()
        {

        }

        // 스킬
        public void skill()
        {

        }

        // 상태이상
        public void Debuff()
        {

        }

    }
}
