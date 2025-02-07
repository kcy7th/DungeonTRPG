namespace DungeonTRPG.Entity.Utility
{
    internal class Stat
    {
        public int Lv { get; }
        public int Exp { get; }
        public int Hp { get; }
        public int MaxHp { get; }
        public int Mp { get; }
        public int MaxMp { get; }
        public int Atk { get; }
        public int Def { get; }


        public Stat(int level, int exp, int hp, int maxHp, int mp, int maxMp, int atk, int def)
        {
            Lv = level;
            Exp = exp;
            Hp = maxHp;
            MaxHp = maxHp;
            Mp = mp;
            MaxMp = maxMp;
            Atk = atk;
            Def = def;
        }
    }
}