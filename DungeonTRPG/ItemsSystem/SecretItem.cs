using System;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;

namespace ungeonTRPG.Items
{
    internal class SecretItem : Item
    {
        public string SpecialEffect { get; }

        public SecretItem(string name, string description, List<Job> allowedJobs, string specialEffect)
            : base(name, description, allowedJobs)
        {
            SpecialEffect = specialEffect;
        }

        public override Item Clone()
        {
            return new SecretItem(name, description, new List<Job>(AllowedJobs), SpecialEffect);
        }

        public override int CompareTo(Item? other)
        {
            if (other is EquipItem) return 0;
            else return 1;
        }
    }

}
