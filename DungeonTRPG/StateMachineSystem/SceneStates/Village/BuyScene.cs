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
        private Shop shop = new Shop();

        public BuyScene(StateMachine stateMachine) : base(stateMachine)
        {
            stateMachine.OnFloorMultiplesTen += OneChanceItems;

            shop.AddItem(2000);
            shop.AddItem(2100);
            shop.AddItem(2200);
            shop.AddItem(3000);
            shop.AddItem(3100);
            shop.AddItem(3200);
            shop.AddItem(4000);
            shop.AddItem(4100);
            shop.AddItem(4200);
            shop.AddItem(5000);
            shop.AddItem(5100);
            shop.AddItem(5200);
            shop.AddItem(6000);
            shop.AddItem(6100);
            shop.AddItem(6200);
            shop.AddItem(7000);
            shop.AddItem(7100);
            shop.AddItem(7200);
        }

        public override void Enter()
        {
            base.Enter();
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
                    Console.WriteLine($"- {i + 1} {shop.Items[i].GetItemInformation()}| {shop.Items[i].Price}G");
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

        private void OneChanceItems()
        {
            switch (stateMachine.currentFloor)
            {
                case 10:
                    shop.AddItem(2001);
                    shop.AddItem(2101);
                    shop.AddItem(2201);
                    shop.AddItem(3001);
                    shop.AddItem(3101);
                    shop.AddItem(3201);
                    shop.AddItem(4001);
                    shop.AddItem(4101);
                    shop.AddItem(4201);
                    shop.AddItem(5001);
                    shop.AddItem(5101);
                    shop.AddItem(5201);
                    shop.AddItem(6001);
                    shop.AddItem(6101);
                    shop.AddItem(6201);
                    shop.AddItem(7001);
                    shop.AddItem(7101);
                    shop.AddItem(7201);
                    break;
                case 20:
                    shop.AddItem(2002);
                    shop.AddItem(2102);
                    shop.AddItem(2202);
                    shop.AddItem(3002);
                    shop.AddItem(3102);
                    shop.AddItem(3202);
                    shop.AddItem(4002);
                    shop.AddItem(4102);
                    shop.AddItem(4202);
                    shop.AddItem(5002);
                    shop.AddItem(5102);
                    shop.AddItem(5202);
                    shop.AddItem(6002);
                    shop.AddItem(6102);
                    shop.AddItem(6202);
                    shop.AddItem(7002);
                    shop.AddItem(7102);
                    shop.AddItem(7202);
                    break;
                case 30:
                    shop.AddItem(2003);
                    shop.AddItem(2103);
                    shop.AddItem(2203);
                    shop.AddItem(3003);
                    shop.AddItem(3103);
                    shop.AddItem(3203);
                    shop.AddItem(4003);
                    shop.AddItem(4103);
                    shop.AddItem(4203);
                    shop.AddItem(5003);
                    shop.AddItem(5103);
                    shop.AddItem(5203);
                    shop.AddItem(6003);
                    shop.AddItem(6103);
                    shop.AddItem(6203);
                    shop.AddItem(7003);
                    shop.AddItem(7103);
                    shop.AddItem(7203);
                    break;
                case 40:
                    shop.AddItem(2004);
                    shop.AddItem(2104);
                    shop.AddItem(2204);
                    shop.AddItem(3004);
                    shop.AddItem(3104);
                    shop.AddItem(3204);
                    shop.AddItem(4004);
                    shop.AddItem(4104);
                    shop.AddItem(4204);
                    shop.AddItem(5004);
                    shop.AddItem(5104);
                    shop.AddItem(5204);
                    shop.AddItem(6004);
                    shop.AddItem(6104);
                    shop.AddItem(6204);
                    shop.AddItem(7004);
                    shop.AddItem(7104);
                    shop.AddItem(7204);
                    break;
                case 50:
                    shop.AddItem(2005);
                    shop.AddItem(2105);
                    shop.AddItem(2205);
                    shop.AddItem(3005);
                    shop.AddItem(3105);
                    shop.AddItem(3205);
                    shop.AddItem(4005);
                    shop.AddItem(4105);
                    shop.AddItem(4205);
                    shop.AddItem(5005);
                    shop.AddItem(5105);
                    shop.AddItem(5205);
                    shop.AddItem(6005);
                    shop.AddItem(6105);
                    shop.AddItem(6205);
                    shop.AddItem(7005);
                    shop.AddItem(7105);
                    shop.AddItem(7205);
                    break;
                case 60:
                    shop.AddItem(2006);
                    shop.AddItem(2106);
                    shop.AddItem(2206);
                    shop.AddItem(3006);
                    shop.AddItem(3106);
                    shop.AddItem(3206);
                    shop.AddItem(4006);
                    shop.AddItem(4106);
                    shop.AddItem(4206);
                    shop.AddItem(5006);
                    shop.AddItem(5106);
                    shop.AddItem(5206);
                    shop.AddItem(6006);
                    shop.AddItem(6106);
                    shop.AddItem(6206);
                    shop.AddItem(7006);
                    shop.AddItem(7106);
                    shop.AddItem(7206);
                    break;
                case 70:
                    shop.AddItem(2007);
                    shop.AddItem(2107);
                    shop.AddItem(2207);
                    shop.AddItem(3007);
                    shop.AddItem(3107);
                    shop.AddItem(3207);
                    shop.AddItem(4007);
                    shop.AddItem(4107);
                    shop.AddItem(4207);
                    shop.AddItem(5007);
                    shop.AddItem(5107);
                    shop.AddItem(5207);
                    shop.AddItem(6007);
                    shop.AddItem(6107);
                    shop.AddItem(6207);
                    shop.AddItem(7007);
                    shop.AddItem(7107);
                    shop.AddItem(7207);
                    break;
                case 80:
                    shop.AddItem(2008);
                    shop.AddItem(2108);
                    shop.AddItem(2208);
                    shop.AddItem(3008);
                    shop.AddItem(3108);
                    shop.AddItem(3208);
                    shop.AddItem(4008);
                    shop.AddItem(4108);
                    shop.AddItem(4208);
                    shop.AddItem(5008);
                    shop.AddItem(5108);
                    shop.AddItem(5208);
                    shop.AddItem(6008);
                    shop.AddItem(6108);
                    shop.AddItem(6208);
                    shop.AddItem(7008);
                    shop.AddItem(7108);
                    shop.AddItem(7208);
                    break;
                case 90:
                    shop.AddItem(2009);
                    shop.AddItem(2109);
                    shop.AddItem(2209);
                    shop.AddItem(3009);
                    shop.AddItem(3109);
                    shop.AddItem(3209);
                    shop.AddItem(4009);
                    shop.AddItem(4109);
                    shop.AddItem(4209);
                    shop.AddItem(5009);
                    shop.AddItem(5109);
                    shop.AddItem(5209);
                    shop.AddItem(6009);
                    shop.AddItem(6109);
                    shop.AddItem(6209);
                    shop.AddItem(7009);
                    shop.AddItem(7109);
                    shop.AddItem(7209);
                    break;
            }
        }
    }
}
