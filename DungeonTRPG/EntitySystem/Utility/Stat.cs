namespace DungeonTRPG.Entity.Utility
{
    internal class Stat
    {
        public int Lv { get; set; }
        public int Exp { get; set; }
        public int CurHp { get; set; }
        public int MaxHp { get; set; }
        public int CurMp { get; set; }
        public int MaxMp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }


        public Stat(int level, int exp, int curHp, int maxHp, int curMp, int maxMp, int atk, int def)
        {
            Lv = level;
            Exp = exp;
            CurHp = curHp;
            MaxHp = maxHp;
            CurMp = curMp;
            MaxMp = maxMp;
            Atk = atk;
            Def = def;
        }
    }
}