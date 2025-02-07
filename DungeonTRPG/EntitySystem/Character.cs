using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity
{

    internal abstract class Character
    {
        private EntityStat stat;
        private State state;
        //private Skill skill;
        private string Name { get; }
        private int Gold { get; set; }

        public Character(string name, int gold)
        {
            Name = name;
            Gold = gold;
        }
    }
}
