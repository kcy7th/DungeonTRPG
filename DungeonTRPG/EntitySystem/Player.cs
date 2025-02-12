using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.EntitySystem
{
    internal class Player : Character
    {
        public Job Job;

        public Player(string name, int gold, Stat stat, Job job) : base(name, gold, stat)
        {
            this.Job = job;
        }

        public override Character Clone()
        {
            return new Player(Name, Gold, Stat, Job);
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
            if (!string.IsNullOrWhiteSpace(name)) // IsNullOrWhiteSpace()로 빈칸이 입력되는 경우까지 방지
            {
                Name = name;
            }            
        }
    }
}
