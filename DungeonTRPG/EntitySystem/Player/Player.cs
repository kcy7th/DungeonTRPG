using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity.Player
{
    internal class Player : Character
    {
        public Job job;

        public Player(string name, int gold, Stat stat, Job job) : base(name, gold, stat)
        {
            this.job = job;
        }

        // 경험치 획득
        public void GetExp(int dropExp)
        {
            Stat.SetExp(Stat.Exp + dropExp);
        }

        // 골드 획득
        public void GetGold(int dropGold)
        {
            Stat.SetGold(Stat.Gold + dropGold);
        }
    }
}
