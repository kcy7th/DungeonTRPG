using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.ShopSystem;
using DungeonTRPG.StateMachineSystem.SceneStates.Combat;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public override void Enter()
        {
            base.Enter();

            ShopInit();
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

            Console.WriteLine("[보유 골드]");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(player.Gold);
            Console.ResetColor();
            Console.WriteLine("G");
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
            InputField("구매하실 아이템 번호를 입력하세요.");
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num == 0) stateMachine.GoPreviousState();
                else if (0 < num && num <= shop.Items.Count)
                {
                    Item item = shop.BuyItem(num - 1);
                    if (player.Gold >= item.Price)
                    {
                        if (player.Inventory.MaxSlots > player.Inventory.Count)
                        {
                            player.SpendGold(item.Price);
                            player.Inventory.AddItem(item);
                            SendMessage($"{item.GetName()}을(를) 구매했습니다!");
                        }
                        else
                        {
                            shop.AddItem(item);
                            SendMessage($"인벤토리가 가득 찼습니다!");
                        }
                    }
                    else
                    {
                        SendMessage("골드가 부족합니다!");
                    }
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }

        private void ShopInit()
        {
            switch (stateMachine.currentFloor)
            {
                case 10:
                    shop.AddItem(1000);
                    break;
                case 20:
                    break;
                case 30:
                    break;
                case 40:
                    break;
                case 50:
                    break;
                case 60:
                    break;
                case 70:
                    break;
                case 80:
                    break;
                case 90:
                    break;
            }
        }
    }
}
