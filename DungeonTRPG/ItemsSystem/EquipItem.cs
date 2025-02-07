using System;
using System.Collections.Generic;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Items
{
    internal class EquipItem : Item
    {
        public EquipItem(string name, string description, List<Job> allowedJobs)
            : base(name, description, allowedJobs)
        {
        }

        // 아이템 복제
        public override Item Clone()
        {
            return new EquipItem(name, description, new List<Job>(AllowedJobs));
        }
    }
}