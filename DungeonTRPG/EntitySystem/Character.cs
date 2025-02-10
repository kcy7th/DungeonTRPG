using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.StateMachineSystem;
using DungeonTRPG.Utility.Enums;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonTRPG.Entity
{

    internal abstract class Character
    {
        public string Name { get; private set; }
        public int Gold { get; private set; }
        public Stat Stat { get; private set; }
               
        public Character(string name, int gold, Stat stat)
        {            
            Name = name;
            Gold = gold;
            Stat = stat;
        }

        // 공격
        public int Attack()
        {
            int damage = Stat.Atk;
            if (damage < 0) damage = 0;
            return damage;
        }

        // 피격
        public void Damaged(int damage)
        {
            Stat.SetDamage(damage);
        }

        // 체력 회복
        public void Heal(int amount)
        {
            Stat.SetHp(Stat.Hp + amount);
        }

        // 마나 사용
        public void UseMana(int amount)
        {
            Stat.SetMp(Stat.Mp - amount);
        }

        // 마나 회복
        public void RecoverMana(int amount)
        {
            Stat.SetMp(Stat.Mp + amount);
        }
    }
}
