using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Utility.Enums;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonTRPG.Entity
{

    internal abstract class Character
    {
        //public Skill skill;
        public string Name { get; private set; }
        public int Gold { get; private set; }
        public Stat Stat { get; private set; }
                       
        public Character(string name, int gold, Stat stat)
        {            
            Name = name;
            Gold = gold;
            Stat = stat;
        }
    }
}
