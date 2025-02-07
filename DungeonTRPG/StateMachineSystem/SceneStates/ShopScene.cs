using DungeonTRPG.Items;
using DungeonTRPG.ShopSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class ShopScene : SceneState
    {
        string input = "";

        // 상점 생성
        Shop shop = new Shop();

        internal ShopScene(StateMachine stateMachine) : base(stateMachine)
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

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("상점");
            Console.ResetColor();
            Console.WriteLine("");
            
            // 선택창 보기 
            ViewSelect();

            // 상점 아이템 보기
            ViewShopItems();

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
                // 마을로 돌아가기 
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
            Console.WriteLine("||           0. 마을          ||");
            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        // 상점 아이템 보기 함수 
        private void ViewShopItems()
        {
            // 상점 아이템 불러오기 
            List<Item> items = shop.GetItems();

            // 상점 아이템 보기
            foreach (Item item in items) 
            {
                Console.WriteLine(item.GetName());
            }
        }
    }
}
