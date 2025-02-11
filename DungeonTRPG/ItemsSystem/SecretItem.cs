using DungeonTRPG.Utility.Enums;
using DungeonTRPG.EntitySystem.ActiveEffect;
using DungeonTRPG.Interface;
using System.Collections.Generic;

namespace DungeonTRPG.Items
{
    internal class SecretItem : ActiveItem
    {
        public int Price { get; }

        public SecretItem(string name, string description, int price, List<Job> allowedJobs, List<IEffect> effects, UseableIn useableIn)
            : base(name, description, price, allowedJobs, effects, useableIn)
        {
            Price = price;
        }

        public override Item Clone()
        {
            return new SecretItem(name, description, Price, new List<Job>(AllowedJobs), new List<IEffect>(effects), UseableIn);
        }

        // 아이템 비교 메서드
        public override int CompareTo(Item? other)
        {
            if (other is SecretItem) return 0;
            if (other is ActiveItem) return 1;
            return -1;
        }
    }
}