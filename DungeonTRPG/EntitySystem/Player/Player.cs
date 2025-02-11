using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity.Player
{
    internal class Player : Character
    {
        public Job Job;

        public Player(string name, int gold, Stat stat, Job job) : base(name, gold, stat)
        {
            this.Job = job;
        }

        // 경험치 획득
        public void GetExp(int dropExp)
        {
            Stat.AddExp(dropExp);
        }

        // 골드 획득
        public void GetGold(int dropGold)
        {
            Gold += dropGold;
        }

        // 플레이어 이름 지정
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
        }
    }
}
