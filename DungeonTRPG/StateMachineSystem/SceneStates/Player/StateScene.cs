using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Player
{
    internal class StateScene : SceneState
    {
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
        }

        // 씬 선택 함수 
        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                // 마을로 돌아가기 
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
                    break;
                // 다른 입력
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        protected override void View()
        {
            ViewStat();
            ViewSelect();
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
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("상태 보기");
            Console.ResetColor();
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("================================");
            Console.WriteLine($"||   이름 :  {stateMachine.Player.Name}||");
            Console.WriteLine($"||   직업 :  {stateMachine.Player.job} ||");
            Console.WriteLine($"||   레벨 :  {stateMachine.Player.Stat.Lv} ||");
            Console.WriteLine($"||   경험치 : {stateMachine.Player.Stat.Exp} ||");
            Console.WriteLine($"||   공격력 : {stateMachine.Player.Stat.Atk} ||");
            Console.WriteLine($"||   방어력 : {stateMachine.Player.Stat.Def} ||");
            Console.WriteLine($"||   현재 HP : {stateMachine.Player.Stat.Hp} / {stateMachine.Player.Stat.MaxHp} ||");
            Console.WriteLine($"||   현재 MP : {stateMachine.Player.Stat.Mp} / {stateMachine.Player.Stat.MaxMp} ||");
            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.ResetColor();
        }

    }
}
