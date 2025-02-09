using DungeonTRPG.ShopSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class SecretBoxScene : SceneState
    {
        string input = "";

        // 상점 생성
        Shop shop = new Shop();

        internal SecretBoxScene(StateMachine stateMachine) : base(stateMachine)
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

            // 의문의 상자
            SecretBoxRoop();
        }

        // 의문의 상자 함수 
        private void SecretBoxRoop()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("의문의 상자");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("의문의 상자를 찾았습니다");
            Console.WriteLine("");
            Console.ResetColor();

            // 선택창 보기 
            ViewSelect();

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
                // 의문의 상자 열어보기
                case "1":
                    OpenSecretBox();
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
            Console.WriteLine("============================================");
            Console.WriteLine("||         행동을 선택해 주세요           ||");
            Console.WriteLine("||      1. 열어보기 0. 던전 돌아가기      ||");
            Console.WriteLine("============================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        // 의문의 상자 열기 함수 
        private void OpenSecretBox()
        {
            // 의문의 상자 열기 함수 로직 추가

        }
    }
}
