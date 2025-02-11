using DungeonTRPG.Entity.Enemy;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class AttackScene : CombatScene
    {
        private int index;

        public AttackScene(StateMachine stateMachine, List<Enemy> enemys, int index) : base(stateMachine, enemys)
        {
            this.index = index;
        }

        public override void Enter()
        {
            base.Enter();
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
            Attack();
        }

        private void Attack()
        {
            Enemy enemy = enemys[index];
            int damaged = enemy.Damaged(inventory.Character.Stat.Atk);

            EnemyStats();

            Console.WriteLine("\n" +
                $"적에게 {damaged}의 데미지를 주었습니다.");
        }

        protected override void Control()
        {
            Thread.Sleep(500);
            stateMachine.ChangeState(new EnemyTurnScene(stateMachine, enemys));
        }
    }
}
