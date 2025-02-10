using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class InventoryScene : SceneState
    {
        string input = "";

        internal InventoryScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update()
        {
            base.Update();

            // 인벤토리
            InventoryLoop();
        }

        // 인벤토리 함수 
        private void InventoryLoop()
        {
            Console.Clear();
            
            // 인벤토리 보기
            ViewInventory();

            // 선택창 보기 
            ViewSelect();

            // 입력
            input = Console.ReadLine();

            // 씬 선택 
            SelectScene(input);
        }

        // 씬 선택 함수 
        private void SelectScene(string input)
        {
            switch (input)
            {
                // 이전으로 돌아가기
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();

                    // 이전 데이터 지우기 
                    stateMachine.PreviousDataClear();
                    break;
                // 다른 입력
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        // 선택창 보기 함수 
        private void ViewSelect()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("================================");
            Console.WriteLine("||  이동할 곳을 선택해 주세요 ||");
            Console.WriteLine("||         0. 돌아가기        ||");
            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        // 인벤토리 보기 함수 
        private void ViewInventory()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("인벤토리");
            Console.ResetColor();
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            // 장착 아이템 출력
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[장착 아이템]");
            Console.ResetColor();

            bool hasEquip = false;
            foreach (EquipSlot slot in Enum.GetValues(typeof(EquipSlot)))
            {
                var equippedItem = stateMachine.PlayerInventory.GetEquippedItem(slot);
                if (equippedItem != null)
                {
                    Console.WriteLine($"- [E] {equippedItem.GetName()} | {equippedItem.GetDescription()}");
                    hasEquip = true;
                }
            }
            if (!hasEquip) Console.WriteLine("보유하신 장착 아이템이 없습니다.");

            Console.WriteLine();

            // 소비 아이템 출력
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[소비 아이템]");
            Console.ResetColor();

            var bags = stateMachine.PlayerInventory.GetBags();
            bool hasActive = false;
            foreach (var bag in bags)
            {
                foreach (var item in bag.GetItems())
                {
                    Console.WriteLine($"- {item.GetName()} | {item.GetDescription()}");
                    hasActive = true;
                }
            }
            if (!hasActive) Console.WriteLine("보유하신 소비 아이템이 없습니다.");

            // 행동 선택
            Console.WriteLine("\n1. 장착 관리");
            Console.WriteLine("0. 나가기");

            Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
        }
    }
}
