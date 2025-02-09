using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity.Player
{
    internal class Player : Character
    {        
        public Job job;

        public event Action? PlayerDefend; // 방어 이벤트
        public event Action? PlayerRun; // 도망 이벤트

        public Player(string name, int gold, Stat stat, Job job) : base(name, gold, stat)
        {
            this.job = job;
        }

        // 방어
        public void Defend()
        {
            PlayerDefend?.Invoke(); 
        }

        // 도망
        public void Run()
        {
            PlayerRun?.Invoke();
        }
    }
}
