using System;
using System.Collections.Generic;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Items
{
    internal class ActiveItem : Item
    {
        public ActiveItem(string name, string description, List<Job> allowedJobs)
            : base(name, description, allowedJobs)
        {
        }

        // 아이템 복제 (가방 내 아이템 관리용)
        public override Item Clone()
        {
            return new ActiveItem(name, description, new List<Job>(AllowedJobs));
        }
    }
}