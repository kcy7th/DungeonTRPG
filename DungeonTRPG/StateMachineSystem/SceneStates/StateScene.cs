using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class StateScene : SceneState
    {
        string input = "";
        internal StateScene(StateMachine stateMachine) : base(stateMachine)
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

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("상태 보기");
            Console.ResetColor();
            Console.WriteLine("");

            // 선택창 보기 
            ViewSelect();

            // 상태 보기
            Console.WriteLine();
            ViewStat();

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

        private void ViewStat()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("================================");
            Console.WriteLine($"||   이름 :  ||");
            Console.WriteLine($"||   직업 :  {stateMachine.Player.job} ||");
            Console.WriteLine($"||   레벨 :  {stateMachine.Player.Entitystat?.Lv} ||");
            Console.WriteLine($"||   경험치 : {stateMachine.Player.Entitystat?.Exp} ||");
            Console.WriteLine($"||   공격력 : {stateMachine.Player.Entitystat?.Atk} ||");
            Console.WriteLine($"||   방어력 : {stateMachine.Player.Entitystat?.Def} ||");
            Console.WriteLine($"||   현재 HP : {stateMachine.Player.Entitystat?.Mp} / {stateMachine.Player.Entitystat?.MaxHp} ||");
            Console.WriteLine($"||   현재 MP : {stateMachine.Player.Entitystat?.Mp} / {stateMachine.Player.Entitystat?.MaxMp} ||");
            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

    }
}
