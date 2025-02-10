using System;
using System.Collections.Generic;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Items
{
    internal class ActiveItem : Item
    {
        public UseableIn UseableIn { get; }

        public ActiveItem(string name, string description, List<Job> allowedJobs, UseableIn useableIn)
            : base(name, description, allowedJobs)
        {
            UseableIn = useableIn;
        }

        // 아이템 복제 (가방 내 아이템 관리용)
        public override Item Clone()
        {
            return new ActiveItem(name, description, new List<Job>(AllowedJobs), UseableIn);
        }

        public override int CompareTo(Item? other)
        {
            if (other is ActiveItem) return 0;
            else return 1;
        }

        public void ItemUse()
        {

        }
    }
}