using DungeonTRPG.EntitySystem;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class PlayerTurnScene : CombatScene
    {
        public PlayerTurnScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Console.Title = "PlayerTurn";

            stateMachine.enemyTurnCount = 0;
            player.Stat.SetDefenseStance(false);

            switch (player.CharacterState.State)
            {
                case State.Sleep:
                    Sleep(player);
                    stateMachine.ChangeState(new EnemyTurnScene(stateMachine));
                    break;
                case State.Burn:
                    player.Damaged(player.Stat.MaxHp / 10);
                    Addiction(player);
                    break;
                case State.Poison:
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
            EnemyStats();

            Console.WriteLine();
            Console.WriteLine("1. 공격");
            Console.WriteLine("2. 스킬");
            Console.WriteLine("3. 아이템");
            Console.WriteLine("4. 방어");
            Console.WriteLine();

            InputField();
            var cursurPos = Console.GetCursorPosition();

            PlayerStats();

            Console.SetCursorPosition(cursurPos.Left, cursurPos.Top);
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    stateMachine.preCombatScene = this;
                    stateMachine.ChangeState(new SelectEnemyScene(stateMachine));
                    break;
                case "2":
                    stateMachine.ChangeState(new CombatSkillScene(stateMachine));
                    break;
                case "3":
                    stateMachine.ChangeState(new CombatItemScene(stateMachine));
                    break;
                case "4":
                    player.Stat.SetDefenseStance(true);
                    stateMachine.ChangeState(new EnemyTurnScene(stateMachine));
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
