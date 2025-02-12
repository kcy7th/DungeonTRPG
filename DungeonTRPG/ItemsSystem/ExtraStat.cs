namespace DungeonTRPG.ItemsSystem
{
    public class ExtraStat
    {
        public ExtraStat(int hp, int mp, int atk, int spellAtk, int def)
        {
            Hp = hp;
            Mp = mp;
            Atk = atk;
            SpellAtk = spellAtk; 
            Def = def;
        }

        public int Hp { get; }
        public int Mp { get; }
        public int Atk { get; }
        public int SpellAtk { get; }
        public int Def { get; }
    }
}
