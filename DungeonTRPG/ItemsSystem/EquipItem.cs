using System;
using System.Collections.Generic;
using DungeonTRPG.ItemsSystem;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Items
{
    internal class EquipItem : Item
    {
        public ExtraStat ExtraStat { get; }

        public EquipSlot Slot { get; } // 장착 슬롯 정보 추가

        public EquipItem(string name, string description, List<Job> allowedJobs, ExtraStat extraStat, EquipSlot slot)
            : base(name, description, allowedJobs)
        {
            Slot = slot;
            ExtraStat = extraStat;
        }

        // 아이템 복제
        public override Item Clone()
        {
            return new EquipItem(name, description, new List<Job>(AllowedJobs), ExtraStat, Slot);
        }
    }
}
