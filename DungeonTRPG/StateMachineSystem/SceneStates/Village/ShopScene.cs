using DungeonTRPG.Items;
using DungeonTRPG.ShopSystem;
using System;
using System.Collections.Generic;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Village
{
    internal class ShopScene : SceneState
    {
        private Shop shop;
        private List<Item> availableItems;

        internal ShopScene(StateMachine stateMachine) : base(stateMachine)
        {
            this.shop = new Shop();
            this.availableItems = shop.GetItems();
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
            Console.WriteLine("상점");
            Console.ResetColor();
            Console.WriteLine("\n상점에 오신 것을 환영합니다!\n");

            ViewShopItems();
            ViewSelect();
        }

        private void ViewShopItems()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[아이템 목록]");
            Console.ResetColor();
            Console.WriteLine("");

            if (availableItems.Count == 0)
            {
                Console.WriteLine("현재 판매 중인 아이템이 없습니다.");
            }
            else
            {
                for (int i = 0; i < availableItems.Count; i++)
                {
                    string itemType = availableItems[i] is EquipItem ? "[장비]" : "[소비]";
                    Console.WriteLine($"- {availableItems[i].GetName()} | {availableItems[i].GetDescription()} | {availableItems[i].Price}G");
                }
            }
        }

        // 구매 메서드
        private void BuyItem(int index)
        {
            Item selectedItem = availableItems[index];

            if (stateMachine.Player.SpendGold(selectedItem.Price))
            {
                shop.BuyItem(selectedItem, stateMachine.Player.Inventory);
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
                        BuyItem(itemIndex - 1);
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
            Console.WriteLine("=======================================");
            Console.WriteLine("||        행동을 선택해 주세요        ||");
            Console.WriteLine("||   1. 구매하기  0. 마을로 돌아가기  ||");
            Console.WriteLine("=======================================");
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