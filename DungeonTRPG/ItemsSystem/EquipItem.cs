using System;
using DungeonTRPG.ItemsSystem;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Items
{
    internal class EquipItem : Item
    {
        public ExtraStat ExtraStat { get; }

        public EquipSlot Slot { get; } // 장착 슬롯 정보 추가
        public bool IsEquipped { get; internal set;}

        public EquipItem(string name, string description, int price, List<Job> allowedJobs, ExtraStat extraStat, EquipSlot slot)
            : base(name, description, price, allowedJobs)
        {
            Slot = slot;
            ExtraStat = extraStat;
        }

        // 아이템 복제
        public override Item Clone()
        {
            return new EquipItem(name, description, Price, new List<Job>(AllowedJobs), ExtraStat, Slot);
        }

        public override int CompareTo(Item? other)
        {
            if (other is EquipItem) return 0;
            else return -1;
        }
    }
}
