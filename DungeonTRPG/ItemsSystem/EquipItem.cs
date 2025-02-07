using System;
using System.Collections.Generic;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Items
{
    internal class EquipItem : Item
    {
        public EquipSlot Slot { get; } // 장착 슬롯 정보 추가

        public EquipItem(string name, string description, List<Job> allowedJobs, EquipSlot slot)
            : base(name, description, allowedJobs)
        {
            Slot = slot;
        }

        // 아이템 복제
        public override Item Clone()
        {
            return new EquipItem(name, description, new List<Job>(AllowedJobs), Slot);
        }
    }
}
