using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Entity
{

    internal abstract class Character
    {
        public EntityStat stat;
        public State state;
        //public Skill skill;
        public string Name { get; }
        public int Gold { get; set; }

        public Character(string name, int gold)
        {
            Name = name;
            Gold = gold;
        }

        public void Attack()
        {

        }
        
        public void Defend()
        {

        }

        public void skill()
        {

        }

        public void UseItem()
        {

        }

        public void Run()
        {

        }

    }
}
