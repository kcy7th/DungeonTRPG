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
        }

        public override void Exit()
        {
            base.Exit();

            foreach (Enemy enemy in enemys)
            {
                enemy.CharacterState.TurnCountDown();
            }

            player.CharacterState.TurnCountDown();
        }

        protected override void View()
        {
            base.View();

            Console.Title = "EnemyTurn";
        }

        protected override void Control()
        {
            if (!CheckState()) return;

            int random = Random.Next(0, 2);

            if (random == 0 || enemy.Skills.Count < 1) enemy.Attack(player);
            else if (random == 1)
            {
                random = Random.Next(0, enemy.Skills.Count);
                enemy.Skills[random].UseSkill(enemy, player);
            }

            Thread.Sleep(1000);
        }

        private bool CheckState()
        {
            if (stateMachine.enemyTurnCount < enemys.Count)
            {
                enemy = enemys[stateMachine.enemyTurnCount];

                stateMachine.enemyTurnCount++;

                if (!enemy.isDead)
                {
                    switch (enemy.CharacterState.State)
                    {
                        case State.Sleep:
                            Sleep(enemy);
                            return false;
                        case State.Addiction:
                            enemy.TrueDamaged(enemy.Stat.MaxHp / 10);
                            Addiction(enemy);
                            break;
                        case State.Confusion:
                            Confusion(enemy);
                            break;
                    }
                }
                else return false;
            }
            else
            {
                int count = 0;
                foreach (Enemy enemy in enemys)
                {
                    if (enemy.isDead) count++;
                }

                if (count == enemys.Count) stateMachine.ChangeState(new PlayerWinScene(stateMachine, enemys));
                else stateMachine.ChangeState(new PlayerTurnScene(stateMachine, enemys));

                return false;
            }

            return true;
        }
    }
}
