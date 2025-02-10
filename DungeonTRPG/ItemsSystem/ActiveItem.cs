using DungeonTRPG.Entity;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Items
{
    internal class ActiveItem : Item
    {
        public UseableIn UseableIn { get; }
        public List<IEffect> effects = new List<IEffect>();

        public ActiveItem(string name, string description, List<Job> allowedJobs, List<IEffect> effects, UseableIn useableIn)
            : base(name, description, allowedJobs)
        {
            UseableIn = useableIn;
            this.effects = effects;
        }

        public ActiveItem(string name, string description, List<Job> allowedJobs, UseableIn useableIn)
            : base(name, description, allowedJobs)
        {
            UseableIn = useableIn;
        }

        // 아이템 복제 (가방 내 아이템 관리용)
        public override Item Clone()
        {
            return new ActiveItem(name, description, new List<Job>(AllowedJobs), effects, UseableIn);
        }

        public override int CompareTo(Item? other)
        {
            if (other is ActiveItem) return 0;
            else return 1;
        }

        public void ItemUse(Character player, Character target)
        {
            foreach(var effect in effects)
            {
                effect.UseEffect(player, target);
            }
        }

        public void AddEffect(IEffect effect)
        {
            effects.Add(effect);
        }
    }
}