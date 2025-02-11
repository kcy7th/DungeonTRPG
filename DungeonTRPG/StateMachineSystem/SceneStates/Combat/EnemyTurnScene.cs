using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class EnemyTurnScene : CombatScene
    {
        private Enemy enemy;

        public EnemyTurnScene(StateMachine stateMachine, List<Enemy> enemys) : base(stateMachine, enemys)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Console.Title = "EnemyTurn";

            if (stateMachine.enemyTurnCount < enemys.Count)
            {
                enemy = enemys[stateMachine.enemyTurnCount];

                switch (enemy.CharacterState.State)
                {
                    case State.Sleep:
                        Sleep(enemy);
                        break;
                    case State.Addiction:
                        Addiction(enemy);
                        break;
                    case State.Confusion:
                        Confusion(enemy);
                        break;
                }
            }
            else
            {
                stateMachine.ChangeState(new PlayerTurnScene(stateMachine, enemys));
            }
        }

        public override void Exit()
        {
            base.Exit();

            stateMachine.enemyTurnCount++;

            player.CharacterState.TurnCountDown();
        }

        protected override void View()
        {
            base.View();
        }

        protected override void Control()
        {
            int random = Random.Next(0, 2);

            if (random == 0 || enemy.Skills.Count < 1) enemy.Attack(player);
            else if (random == 1)
            {
                random = Random.Next(0, enemy.Skills.Count);
                enemy.Skills[random].UseSkill(enemy, player);
            }

            Thread.Sleep(1000);

            stateMachine.ChangeState(new EnemyTurnScene(stateMachine, enemys));
        }
    }
}
