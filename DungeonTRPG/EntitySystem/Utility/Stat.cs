using DungeonTRPG.EntitySystem.Utility;

namespace DungeonTRPG.Entity.Utility
{
    internal class Stat
    {
        public int Lv { get; private set; }
        public int Exp { get; private set; }
        public int Hp { get; private set; }
        public int MaxHp { get; private set; }
        public int Mp { get; private set; }
        public int MaxMp { get; private set; }
        public int Atk { get; private set; }
        public int Def { get; private set; }

        public event Action? CharacterDie; // 죽음 이벤트

        public Stat(int level, int exp, int hp, int maxHp, int mp, int maxMp, int atk, int def)
        {
            Lv = level;
            Exp = exp;
            Hp = hp;
            MaxHp = maxHp;
            Mp = mp;
            MaxMp = maxMp;
            Atk = atk;
            Def = def;
        }

        // 경험치 관리
        public void AddExp(int value)
        {
            Exp += value;
            while (Exp >= 100) // 한번에 여러번 레벨업 할 경우를 생각하여 반복문
            {
                Exp -= 100; // 100이 넘는 경험치를 얻을 경우 남은 경험치 유지
                Lv++;
                Hp = MaxHp;
            }
        }

        // 데미지 관리
        public void TakeDamage(int damage)
        {
            Hp -= damage;
            if (Hp <= 0)
            {
                Hp = 0;
                CharacterDie?.Invoke();
            }
        }

        internal void SetMaxHp(int value)
        {
            if (value <= 0) return;
            MaxHp = value;
        }

        // 체력 관리
        public void SetHp(int value)
        {
            if (value < 0) Hp = 0;
            else if (value > MaxHp) Hp = MaxHp;
            else Hp = value;
        }

        internal void SetMaxMp(int value)
        {
            if (value <= 0) return;
            MaxHp = value;
        }

        // 마나 관리
        public void SetMp(int value)
        {
            if (value < 0) Mp = 0;
            else if (value > MaxMp) Mp = MaxMp;
            else Mp = value;
        }
        
        public void SetDef(int value)
        {
            if (value < 0) Def = 0;
            else Def = value;
        }

        public void SetAtk(int value)
        {
            if (value < 0) Atk = 0;
            else Atk = value;
        }
    }
}