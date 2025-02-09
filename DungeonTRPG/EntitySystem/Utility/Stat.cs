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

        // 공격
        public int Attack()
        {
            int damage = Atk;
            if (damage < 0) damage = 0;
            return damage;
        }

        // 피격
        public void Damaged(int damage)
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
            if (Hp < 0) Hp = 0;
            if (value > MaxHp) Hp = MaxHp;
            Hp = value;
        }

        // 마나 관리
        public void SetMp(int amount)
        {
            Mp += amount;
            if (Mp < 0) Mp = 0;
            if (Mp > MaxHp) Mp = MaxMp;
        }
    }
}