using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.ShopSystem;
using System;
using System.Collections.Generic;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Village
{
    internal class ShopScene : SceneState
    {
        internal ShopScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        protected override void View()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("상점");
            Console.ResetColor();
            Console.WriteLine("\n상점에 오신 것을 환영합니다!\n");

            Console.WriteLine("1. 구매하기");
            Console.WriteLine("2. 판매하기");
            Console.WriteLine("0. 돌아가기");

            Console.WriteLine();

            InputField();
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    stateMachine.ChangeState(new BuyScene(stateMachine));
                    break;
                case "2":
                    stateMachine.ChangeState(new SellScene(stateMachine));
                    break;
                case "0":
                    stateMachine.GoPreviousState();
                    break;
            }
        }
    }
}