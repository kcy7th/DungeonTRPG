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

        public override void Enter()
        {
            base.Enter();
            View();
        }

        protected override void View()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("비밀 상점");
            Console.ResetColor();
            Console.WriteLine("\n비밀 상점을 찾았습니다!\n");

            ViewSecretShopItems();
            ViewSelect();
        }

        private void ViewSecretShopItems()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[아이템 목록]");
            Console.ResetColor();
            Console.WriteLine("");

            for (int i = 0; i < availableItems.Count; i++)
            {
                Console.WriteLine($"- {availableItems[i].GetName()} | {availableItems[i].GetDescription()} | {availableItems[i].Price}G");
            }
        }

        // 구매 메서드
        private void BuySecretItem(int index)
        {
            Item selectedItem = availableItems[index];

            if (stateMachine.Player.SpendGold(selectedItem.Price))
            {
                secretShop.BuyItem(selectedItem, stateMachine.Player.Inventory);
                availableItems.RemoveAt(index);
                Console.WriteLine($"{selectedItem.GetName()}을(를) 구매했습니다!");
            }
            else
            {
                Console.WriteLine("골드가 부족합니다!");
            }

            Console.WriteLine("\n>>");
            Console.ReadKey();
            View();
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("구매할 아이템 번호를 입력하세요:");
                    string itemInput = Console.ReadLine();
                    if (int.TryParse(itemInput, out int itemIndex) && itemIndex > 0 && itemIndex <= availableItems.Count)
                    {
                        BuySecretItem(itemIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                    break;
                case "0":
                    stateMachine.GoPreviousState();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        private void ViewSelect()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n");
            Console.WriteLine("==========================================");
            Console.WriteLine("||           행동을 선택해 주세요        ||");
            Console.WriteLine("||   1. 구매하기  0. 던전으로 돌아가기   ||");
            Console.WriteLine("==========================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update()
        {
            base.Update();
        }
    }
}