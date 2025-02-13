namespace DungeonTRPG.EntitySystem.Utility
{
    internal class Stat
    {
        public int Lv { get; private set; }
        public int Exp { get; private set; }
        public int MaxExp { get; private set; }
        public int Hp { get; private set; }
        public int MaxHp { get; private set; }
        public int Mp { get; private set; }
        public int MaxMp { get; private set; }
        public int Atk { get; private set; }
        public int SpellAtk { get; private set; }
        public int Def { get; private set; }

        public bool isDefenseStance { get; private set; } = false;

        public event Action? CharacterDie; // 죽음 이벤트

        public Stat(int level, int maxExp, int maxHp, int maxMp, int atk, int spellAtk, int def)
        {
            Lv = level;
            Exp = 0;
            MaxExp = maxExp;
            Hp = maxHp;
            MaxHp = maxHp;
            Mp = maxMp;
            MaxMp = maxMp;
            Atk = atk;
            SpellAtk = spellAtk;
            Def = def;
        }

        // 경험치 관리
        public void AddExp(int value)
        {
            Exp += value;
        }

        public void SetExp(int value)
        {
            Exp = value;
        }

        public void LevelUp()
        {
            Lv++;
            MaxExp = (int)(MaxExp * 1.1f);
            Hp = MaxHp;
        }

        // 데미지 관리
        public int TakeDamage(int damage)
        {
            if (damage < Def) return 0;

            int calculate = damage;

            if (isDefenseStance) calculate = (int)(calculate * 0.2f);

            calculate = calculate - (int)(Def / 5.0f);

            Hp -= calculate;

            if (Hp <= 0)
            {
                Hp = 0;
                CharacterDie?.Invoke();
            }

            return calculate;
        }

        public int TakeTrueDamage(int damage)
        {
            Hp -= damage;

            if (Hp <= 0)
            {
                Hp = 0;
                CharacterDie?.Invoke();
            }

            return Hp;
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
            MaxMp = value;
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

        public void SetSpellAtk(int value)
        {
            if (value < 0) SpellAtk = 0;
            else SpellAtk = value;
        }

        public void SetDefenseStance(bool defenseStance)
        {
            isDefenseStance = defenseStance;
        }

        public Stat Clone()
        {
            return new Stat(Lv, MaxExp, MaxHp, MaxMp, Atk, SpellAtk, Def);
        }
    }
}