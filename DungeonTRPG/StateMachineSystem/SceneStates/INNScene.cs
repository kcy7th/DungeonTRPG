using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class INNScene : SceneState
    {
        string input = "";

        Stopwatch stopwatch = new Stopwatch();

        int restCount = 0;

        internal INNScene(StateMachine stateMachine) : base(stateMachine)
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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("여관");
            Console.ResetColor();
            Console.WriteLine("");


            // 선택창 보기 
            ViewSelect();

            if (restCount > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"HP MP가 {restCount} 회복되었습니다.");
                Console.WriteLine("");
                Console.ResetColor();              
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
                // 마을으로 돌아가기
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();

                    // 이전 데이터 지우기 
                    stateMachine.PreviousDataClear();                   
                    break;
                case "1":
                    // 휴식 취하기
                    GetSomeRest();
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
            Console.WriteLine("=====================================");
            Console.WriteLine("||       행동을 선택해 주세요      ||");
            Console.WriteLine("||   1. 휴식   0.마을로 돌아가기   ||");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        // 휴식 취하기 함수 
        private void GetSomeRest()
        {
            // 5초마다 회복
            stopwatch.Restart();
            Thread.Sleep(1000);

            // HP MP 회복 로직 추가 필요            
            restCount++;

            stopwatch.Stop();
        }
    }
}
