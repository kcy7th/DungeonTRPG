using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.ShopSystem;
using DungeonTRPG.StateMachineSystem.SceneStates.Combat;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Village
{
    internal class BuyScene : SceneState
    {
        private Shop shop;

        public BuyScene(StateMachine stateMachine) : base(stateMachine)
        {
            shop = new Shop();
            shop.AddItem(1000);
        }

        protected override void View()
        {
            ViewShopItems();

        }

        private void ViewShopItems()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("상점");
            Console.ResetColor();
            Console.WriteLine(" - [구매]");
            Console.WriteLine();

            if (shop.Items.Count == 0)
            {
                Console.WriteLine("현재 판매 중인 아이템이 없습니다.");
            }
            else
            {
                for (int i = 0; i < shop.Items.Count; i++)
                {
                    string itemType = shop.BoundaryIndex <= i ? "[소비 아이템]" : "[장비 아이템]";
                    Console.WriteLine($"- {i + 1} {itemType} {shop.Items[i].GetItemInformation()} | {shop.Items[i].Price}G");
                }
            }

            Console.WriteLine();

            Console.WriteLine("0. 돌아가기");
            Console.WriteLine();

            InputField("구매하고 싶은 아이템 번호를 입력하세요.");
        }

        // 구매 메서드
        private void BuyItem(int index)
        {
            Item selectedItem = shop.Items[index];

            if (stateMachine.Player.SpendGold(selectedItem.Price))
            {
                Item item = shop.BuyItem(index);
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
                else if (0 < num && num <= shop.Items.Count)
                {
                    BuyItem(num - 1);
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
