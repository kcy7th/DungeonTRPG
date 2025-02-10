using DungeonTRPG.Entity.Enemy;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class ActionScene : CombatScene
    {
        private int index;

        public ActionScene(StateMachine stateMachine, List<Enemy> enemys, int index) : base(stateMachine, enemys)
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
            EnemyStats();
            Thread.Sleep(100);
            Console.Clear();
            Thread.Sleep(100);
            EnemyStats();
            Thread.Sleep(100);
            Console.Clear();
            Thread.Sleep(100);
            EnemyStats();
            Thread.Sleep(100);
            Console.Clear();
            Thread.Sleep(100);
            EnemyStats();
        }

        protected override void Control()
        {
            if(stateMachine.preCombatScene is PlayerTurnScene) stateMachine.ChangeState(new AttackScene(stateMachine, enemys, index));
            else if (stateMachine.preCombatScene is CombatSkillScene) stateMachine.ChangeState(new SkillAttackScene(stateMachine, enemys, index));
            else if (stateMachine.preCombatScene is CombatItemScene) stateMachine.ChangeState(new AttackScene(stateMachine, enemys, index));
        }
    }
}
