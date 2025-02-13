using DungeonTRPG.Items;
using DungeonTRPG.ShopSystem;
using System;
using System.Collections.Generic;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Dungeon
{
    internal class SecretShopScene : DungeonScene
    {
        private SecretShop secretShop;


        internal SecretShopScene(StateMachine stateMachine) : base(stateMachine)
        {
            this.secretShop = new SecretShop();
        }


        protected override void View()
        {
            ViewSecretShopItems();
        }

        private void ViewSecretShopItems()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("비밀 상점");
            Console.ResetColor();
            Console.WriteLine("\n비밀 상점을 찾았습니다!\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[비밀 상점 아이템 목록]");
            Console.ResetColor();
            Console.WriteLine("");

            if (secretShop.Items.Count == 0)
            {
                Console.WriteLine("현재 판매 중인 아이템이 없습니다.");
            }
            else
            {
                for (int i = 0; i < secretShop.Items.Count; i++)
                {
                    string itemType = secretShop.BoundaryIndex <= i ? "[소비 아이템]" : "[장비 아이템]";
                    Console.WriteLine($"- {i + 1} {itemType} {secretShop.Items[i].GetItemInformation()} | {secretShop.Items[i].Price}G");
                }
            }

            Console.WriteLine();

            Console.WriteLine("0. 돌아가기");
            Console.WriteLine();

            InputField("구매하고 싶은 아이템 번호를 입력하세요.");
        }

        private void BuySecretItem(int index)
        {
            Item selectedItem = secretShop.Items[index];

            if (stateMachine.Player.SpendGold(selectedItem.Price))
            {
                Item item = secretShop.BuyItem(index);
                SendMessage($"{selectedItem.GetName()}을(를) 구매했습니다!");
            }
            else
            {
                SendMessage("골드가 부족합니다!");
            }
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num == 0) stateMachine.GoPreviousState();
                else if (0 < num && num <= secretShop.Items.Count)
                {
                    BuySecretItem(num - 1);
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
