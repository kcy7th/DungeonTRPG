using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonTRPG.Entity.Utility
{
    internal class EntityStat
    {
        private int Level { get; }
        private int Exp { get; }
        private int Hp { get; }
        private int MaxHp { get; }
        private int Mp { get; }
        private int MaxMp { get; }
        private int Atk { get; }
        private int Def { get; }


        public EntityStat(int level, int exp, int hp, int maxHp, int mp, int maxMp, int atk, int def)
        {
            Level = level;
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