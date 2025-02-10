using DungeonTRPG.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Village
{
    internal class INNScene : SceneState
    {
        public Stopwatch stopwatch = new Stopwatch();

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

            // 여관
            View();
        }

        // 여관 함수 
        protected override void View()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("여관");
            Console.ResetColor();
            Console.WriteLine("");

            // 선택창 보기 
            ViewSelect();

            if (restCount > 0)
            {
                ViewHpMp();
            }
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================");
            Console.WriteLine("||       행동을 선택해 주세요      ||");
            Console.WriteLine("||   1. 휴식   0.마을로 돌아가기   ||");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

        // 휴식 취하기 함수 
        public void GetSomeRest()
        {
            // 5초마다 회복
            stopwatch.Restart();
            Thread.Sleep(1000);

            // HP MP 회복 로직 추가 필요            
            restCount++;
            stateMachine.Player.Heal(restCount * 10);
            stateMachine.Player.RecoverMana(restCount * 5);

            stopwatch.Stop();
        }

        public void ViewHpMp()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (stateMachine.Player.Stat.Hp == stateMachine.Player.Stat.MaxHp)
            {
                Console.WriteLine("HP가 모두 회복되었습니다.");
            }
            else
            {
                Console.WriteLine($"HP가 {restCount * 10} 회복되었습니다.");
            }
            if (stateMachine.Player.Stat.Mp == stateMachine.Player.Stat.MaxMp)
            {
                Console.WriteLine("MP가 모두 회복되었습니다.");
            }
            else
            {
                Console.WriteLine($"MP가 {restCount * 5} 회복되었습니다.");
            }
            Console.WriteLine("");
            Console.WriteLine($"현재 HP는 {stateMachine.Player.Stat.Hp}입니다.");
            Console.WriteLine($"현재 MP는 {stateMachine.Player.Stat.Mp}입니다.");
            Console.ResetColor();
        }
    }
}
