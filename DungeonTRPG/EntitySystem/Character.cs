using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;

namespace DungeonTRPG.Entity
{

    internal abstract class Character
    {
        public EntityStat stat;
        public State state;
        //public Skill skill;
        public string Name { get; }
        public int Gold { get; }

        public Character(string name, int gold)
        {
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
        
        // 스킬
        public void skill()
        {

        }

        // 도망
        public void Run()
        {

        }

        // 골드 관리
        public void ManageGold()
        {

        }

        // 상태이상
        public void Debuff()
        {

        }
    }
}
