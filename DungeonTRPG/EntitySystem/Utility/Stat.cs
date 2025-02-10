using DungeonTRPG.EntitySystem.Utility;

namespace DungeonTRPG.Entity.Utility
{
    internal class Stat
    {
        public int Lv { get; private set; }
        public int Exp { get; private set; }
        public int Gold { get; private set; }
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
        public void SetExp(int value)
        {
            Exp = value;
            while (Exp >= 100) // 한번에 여러번 레벨업 할 경우를 생각하여 반복문
            {
                Exp -= 100; // 100이 넘는 경험치를 얻을 경우 남은 경험치 유지
                Lv++;
                Hp = MaxHp;
            }
        }

        // 골드 관리
        public void SetGold(int value)
        {
            Gold = value;
        }

        // 데미지 관리
        public void SetDamage(int damage)
        {
            Hp -= damage;
            if (Hp <= 0)
            {
                Hp = 0;
                CharacterDie?.Invoke();
            }
        }

        // 체력 관리
        public void SetHp(int value)
        {
            if (value < 0) Hp = 0;
            else if (value > MaxHp) Hp = MaxHp;
            else Hp = value;
        }

        // 마나 관리
        public void SetMp(int value)
        {
            if (value < 0) Mp = 0;
            else if (value > MaxMp) Mp = MaxMp;
            else Mp = value;
        }
    }
}