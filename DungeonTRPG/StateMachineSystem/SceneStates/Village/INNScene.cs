using System.Collections.Generic;
using System.Diagnostics;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Village
{
    internal class INNScene : SceneState
    {
        public Stopwatch stopwatch = new Stopwatch();

        internal INNScene(StateMachine stateMachine) : base(stateMachine)
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

            // 여관
            View();
        }

        // 여관 함수 
        protected override void View()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("여관");
            Console.ResetColor();
            Console.WriteLine("휴식을 취할 수 있는 여관입니다.");

            // 선택창 보기 
            ViewSelect();
        }

        // 씬 선택 함수 
        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                // 마을으로 돌아가기
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
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
            Console.WriteLine(
                $"\n" +
                $"1. 휴식 취하기 \n" +
                $"0. 마을로 돌아가기 \n");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");            
        }

        // 휴식 취하기 함수 
        public void GetSomeRest()
        {
            // 5초마다 회복
            stopwatch.Restart();
            Thread.Sleep(1000);
         
            stateMachine.Player.Heal(stateMachine.Player.Stat.MaxHp);
            stateMachine.Player.RecoverMana(stateMachine.Player.Stat.MaxMp);

            stopwatch.Stop();
        }
    }
}
