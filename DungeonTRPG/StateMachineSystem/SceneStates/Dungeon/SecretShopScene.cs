using DungeonTRPG.Items;
using DungeonTRPG.ShopSystem;
using System;
using System.Collections.Generic;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Dungeon
{
    internal class SecretShopScene : DungeonScene
    {
        private SecretShop secretShop;
        private List<Item> availableItems;

        internal SecretShopScene(StateMachine stateMachine) : base(stateMachine)
        {
            this.secretShop = new SecretShop();
            this.availableItems = secretShop.GetItems();
        }

        protected override void View()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("비밀 상점");
            Console.ResetColor();
            Console.WriteLine("\n비밀 상점을 찾았습니다!\n");
        }
    }
}