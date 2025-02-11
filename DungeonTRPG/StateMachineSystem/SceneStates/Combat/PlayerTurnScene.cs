﻿using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class PlayerTurnScene : CombatScene
    {
        public PlayerTurnScene(StateMachine stateMachine, List<Enemy> enemys) : base(stateMachine, enemys)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Console.Title = "PlayerTurn";

            stateMachine.enemyTurnCount = 0;

            switch (player.CharacterState.State)
            {
                case State.Sleep:
                    Sleep(player);
                    stateMachine.ChangeState(new EnemyTurnScene(stateMachine, enemys));
                    break;
                case State.Addiction:
                    player.Damaged(player.Stat.MaxHp / 10);
                    Addiction(player);
                    break;
                case State.Confusion:
                    Confusion(player);
                    break;
            }
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Exit()
        {
            base.Exit();
        }

        protected override void View()
        {
            base.View();

            Console.WriteLine(
                $"\n" +
                $"1. 공격 \n" +
                $"2. 스킬 \n" +
                $"3. 아이템 \n" +
                $"4. 방어 \n");
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    stateMachine.preCombatScene = this;
                    stateMachine.ChangeState(new SelectEnemyScene(stateMachine, enemys));
                    break;
                case "2":
                    stateMachine.ChangeState(new CombatSkillScene(stateMachine, enemys));
                    break;
                case "3":
                    stateMachine.ChangeState(new CombatItemScene(stateMachine, enemys));
                    break;
                case "4":
                    break;
                case "0":
                    // 이전 상태로 돌아가기 
                    stateMachine.GoPreviousState();
                    break;
                default:
                    break;
            }
        }
    }
}
