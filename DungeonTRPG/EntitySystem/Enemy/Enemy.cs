using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;

namespace DungeonTRPG.Entity.Enemy
{
    internal class Enemy : Character
    {
        public Enemy(string name, int gold, Stat stat, State state) : base(name, gold, stat, state)
        {
            
        }


        // 아이템 드롭
        public void DropItem()
        {

        }

        // 경험치 드롭
        public void DropExp()
        {

        }

        // 골드 드롭
        public void DropGold()
        {

        }
    }
}
