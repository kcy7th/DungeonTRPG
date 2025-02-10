using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.ItemsSystem
{
    public class ExtraStat
    {
        public ExtraStat(int hp, int mp, int atk, int def)
        {
            Hp = hp;
            Mp = mp;
            Atk = atk;
            Def = def;
        }

        public int Hp { get; }
        public int Mp { get; }
        public int Atk { get; }
        public int Def { get; }
    }
}
