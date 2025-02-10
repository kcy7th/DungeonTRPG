using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.StateMachineSystem;
using DungeonTRPG.Utility.Enums;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonTRPG.Entity
{

    internal abstract class Character
    {
        public string Name { get; protected set; }
        public int Gold { get; protected set; }
        public Stat Stat { get; protected set; }
        public Inventory Inventory { get; protected set; }

        public Character(string name, int gold, Stat stat)
        {            
            Name = name;
            Gold = gold;
            Stat = stat;
            Inventory = new Inventory();

            Inventory.OnItemEquip += ItemEquip;
            Inventory.OnItemUnEquip += ItemUnEquip;
        }

        private void ItemEquip(EquipItem item)
        {
            Stat.SetMaxHp(Stat.MaxHp + item.ExtraStat.Hp);
            Stat.SetMaxMp(Stat.MaxMp + item.ExtraStat.Mp);
            Stat.SetAtk(Stat.Atk + item.ExtraStat.Atk);
            Stat.SetDef(Stat.Def + item.ExtraStat.Def);
        }

        private void ItemUnEquip(EquipItem item)
        {
            Stat.SetMaxHp(Stat.MaxHp - item.ExtraStat.Hp);
            Stat.SetMaxMp(Stat.MaxMp - item.ExtraStat.Mp);
            Stat.SetAtk(Stat.Atk - item.ExtraStat.Atk);
            Stat.SetDef(Stat.Def - item.ExtraStat.Def);
        }

        // 공격
        public void Attack(Character target)
        {
            int damage = Stat.Atk;
            if (damage < 0) damage = 0;
            target.Damaged(damage);
        }

        // 피격
        public void Damaged(int damage)
        {
            Stat.TakeDamage(damage);
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
