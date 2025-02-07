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

            Console.WriteLine("상점");
            Console.WriteLine("");
            ViewSelect();
            input = Console.ReadLine();
            SelectScene(input);
        }

        private void SelectScene(string input)
        {
            switch (input)
            {
                case "1":
                    stateMachine.GoPreviousState();
                    stateMachine.PreviousDataClear();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
        private void ViewSelect()
        {
            Console.WriteLine("1. 마을");
            Console.WriteLine("");
        }
    }
}
