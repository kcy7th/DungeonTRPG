using DungeonTRPG.EntitySystem;
using DungeonTRPG.Interface;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Items
{
    internal class ActiveItem : Item
    {
        public UseableIn UseableIn { get; }
        public List<IEffect> effects = new List<IEffect>();
        public bool useOnSelf = true;

        public ActiveItem(string name, string description, int price, List<Job> allowedJobs, List<IEffect> effects, UseableIn useableIn, bool useOnSelf)
            : base(name, description, price, allowedJobs)
        {
            UseableIn = useableIn;
            this.effects = effects;
            this.useOnSelf = useOnSelf;
        }

        public ActiveItem(string name, string description, int price, List<Job> allowedJobs, UseableIn useableIn, bool useOnSelf)
            : base(name, description, price, allowedJobs)
        {
            UseableIn = useableIn;
            this.useOnSelf = useOnSelf;
        }

        // 아이템 복제 (가방 내 아이템 관리용)
        public override Item Clone()
        {
            return new ActiveItem(name, description, Price, new List<Job>(AllowedJobs), effects, UseableIn, useOnSelf);
        }

        public override int CompareTo(Item? other)
        {
            if (other is ActiveItem)
            {
                return this.name.CompareTo(other.GetName());
            }
            else return 1;
        }

        public void ItemUse(Character player, List<Character> targets)
        {
            foreach(var effect in effects)
            {
                effect.UseEffect(player, targets);
            }
        }

        public void AddEffect(IEffect effect)
        {
            effects.Add(effect);
        }
    }
}