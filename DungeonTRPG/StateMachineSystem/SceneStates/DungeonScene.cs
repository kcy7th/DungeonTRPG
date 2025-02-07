using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates
{
    internal class DungeonScene : SceneState
    {
        string input = "";
        internal DungeonScene(StateMachine stateMachine) : base(stateMachine)
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

            Console.WriteLine("Dungeon");
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
                    break;
            }
        }
        private void ViewSelect()
        {
            Console.WriteLine("1. 마을");
        }
    }
}
