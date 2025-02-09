using DungeonTRPG.Items;
using DungeonTRPG.ShopSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class SecretShopScene : SceneState
    {
        string input = "";

        // 상점 생성
        Shop shop = new Shop();

        internal SecretShopScene(StateMachine stateMachine) : base(stateMachine)
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

            // 비밀 상점 
            SecretShopRoop();
        }

        // 비밀 상점 함수 
        private void SecretShopRoop()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("비밀 상점");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("비밀 상점을 찾았습니다");
            Console.WriteLine("");
            Console.ResetColor();

            // 행동 선택창 보기 
            ViewSelect();

            // 비밀 상점 아이템 보기
            ViewSecretShopItems();

            // 입력
            input = Console.ReadLine();

            // 행동 선택 
            SelectAction(input);
        }

        // 행동 선택 함수 
        private void SelectAction(string input)
        {
            switch (input)
            {
                // 던전으로 돌아가기 
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();

                    // 이전 데이터 지우기 
                    stateMachine.PreviousDataClear();
                    break;
                // 구매하기  
                case "1":
                    // 구매하기 로직 추가 
                    break;
                // 다른 입력 
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        // 행동 선택창 보기 함수 
        private void ViewSelect()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===================================================");
            Console.WriteLine("||                행동을 선택해 주세요           ||");
            Console.WriteLine("||      1. 아이템 구매하기 0. 던전 돌아가기      ||");
            Console.WriteLine("===================================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        // 비밀 상점 아이템 보기 함수 
        private void ViewSecretShopItems()
        {
            // 비밀 상점 아이템 보기 추가
            
        }
    }
}
