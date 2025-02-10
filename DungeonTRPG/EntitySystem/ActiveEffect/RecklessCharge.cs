using DungeonTRPG.Entity;
using DungeonTRPG.Interface;

namespace DungeonTRPG.EntitySystem.ActiveEffect
{
    internal class RecklessCharge: IEffect
    {

        private int amount;

        public RecklessCharge(int amount)
        {
            this.amount = amount;
        }

        public void UseEffect(Character player, Character enemy)
        {
            player.Stat.TakeDamage(2);
            enemy.Stat.TakeDamage((int)(amount + player.Stat.Atk * 1));
        }
    }
}
