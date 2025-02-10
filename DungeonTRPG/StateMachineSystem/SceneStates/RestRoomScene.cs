using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class RestRoomScene : SceneState
    {
        string input = "";

        int restCount = 0;

        internal RestRoomScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            // 휴식 데이터 초기화
            restCount = 0;
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update()
        {
            base.Update();

            // 휴식 공간
            RestRoomRoop();
        }

        // 휴식 공간 함수
        private void RestRoomRoop()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("휴식 공간");
            Console.ResetColor();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("휴식 공간을 찾았습니다.");
            Console.ResetColor();



            // 선택창 보기 
            ViewSelect();

            if (restCount > 0)
            {
                stateMachine.InnScene.ViewHpMp();
            }

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
                case "1":
                    // 휴식 취하기
                    restCount++;
                    stateMachine.InnScene.GetSomeRest();
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
            Console.WriteLine("=================================");
            Console.WriteLine("||     행동을 선택해 주세요    ||");
            Console.WriteLine("||   1. 휴식 0.던전 돌아가기   ||");
            Console.WriteLine("=================================");
            Console.WriteLine("");
            Console.ResetColor();
        }
    }
}
