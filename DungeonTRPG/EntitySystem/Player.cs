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

        public void AddExp(int value)
        {
            Stat.AddExp(value);
            CheckExp();
        }

        private void CheckExp()
        {
            while(Stat.Exp >= Stat.MaxExp)
            {
                Stat.AddExp(-Stat.MaxExp);
                LevelUp();
            }
        }

        private void LevelUp()
        {
            switch(Job)
            {
                case Job.Warrior:
                    Stat.SetMaxHp(Stat.MaxHp + 20);
                    Stat.SetMaxMp(Stat.MaxMp + 5);
                    Stat.SetAtk(Stat.Atk + 3);
                    Stat.SetDef(Stat.Def + 2);
                    break;
                case Job.Mage:
                    Stat.SetMaxHp(Stat.MaxHp + 10);
                    Stat.SetMaxMp(Stat.MaxMp + 10);
                    Stat.SetSpellAtk(Stat.SpellAtk + 5);
                    Stat.SetDef(Stat.Def + 1);
                    break;
                case Job.Archer:
                    Stat.SetMaxHp(Stat.MaxHp + 15);
                    Stat.SetMaxMp(Stat.MaxMp + 5);
                    Stat.SetAtk(Stat.Atk + 2);
                    Stat.SetSpellAtk(Stat.SpellAtk + 1);
                    Stat.SetDef(Stat.Def + 2);
                    break;
            }

            Stat.LevelUp();
        }
    }
}
