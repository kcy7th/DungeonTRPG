using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Player
{
    internal class ItemUseScene : SceneState
    {
        private Inventory inventory;
        private List<Item> items;
        internal ItemUseScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            inventory = stateMachine.Player.Inventory;
            items = inventory.GetItems();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update()
        {
            base.Update();
        }

        protected override void View()
        {
            // 장착 아이템 출력
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[소비 아이템]");
            Console.ResetColor();

            bool hasEquip = false;
            for (int i = inventory.boundaryIndex; i < items.Count; i++)
            {
                if (items[i] is ActiveItem)
                {
                    Console.WriteLine($"- {i - (inventory.boundaryIndex - 1)} {items[i].GetName()} | {items[i].GetDescription()}");
                    hasEquip = true;
                }
            }
            if (!hasEquip) Console.WriteLine("보유하신 소비 아이템이 없습니다. \n");

            Console.WriteLine();

            // 행동 선택
            Console.WriteLine("0. 나가기");

            Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num == 0) stateMachine.GoPreviousState();
                else if (0 < num && num <= items.Count - inventory.boundaryIndex)
                {
                    ActiveItem item = (ActiveItem)items[num + (inventory.boundaryIndex - 1)];
                    if (stateMachine.isCombat) inventory.ItemUse(num + (inventory.boundaryIndex - 1), stateMachine.Player, stateMachine.Enemy);
                    else
                    {
                        if (UseableIn.OnlyCombat == item.UseableIn) SendMessage("전투 중에만 사용할 수 있습니다.");
                        else inventory.ItemUse(num + (inventory.boundaryIndex - 1), stateMachine.Player, stateMachine.Enemy);
                    }
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
