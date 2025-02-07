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
            isDefense = true;
        }

        // 아이템 사용
        public void UseItem()
        {
            Console.WriteLine("사용할 아이템의 번호를 입력해주세요");
            string itemNum = Console.ReadLine();
            int choice = int.Parse(itemNum);

            switch (choice)
            {
                case 0:
                    // 아이템 1
                    break;
                case 1:
                    // 아이템 2
                    break;
                // ...
                default:
                    break;
            }
        }
    }
}
