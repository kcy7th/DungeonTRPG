using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity.Player
{
    internal class Player : Character
    {
        public Job job;

        public Player(string name, int gold, Stat stat, State state, Job job) : base(name, gold, stat, state)
        {
            this.job = job;
        }

        // 방어
        public void Defend()
        {

        }

        // 아이템 사용
        public void UseItem()
        {

        }

        // 도망
        public void Run()
        {

        }
    }
}
