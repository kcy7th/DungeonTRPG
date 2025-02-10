using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class CombatScene : SceneState
    {
        protected List<Enemy> enemys;
        protected Inventory inventory;
        protected List<Item> items;
        protected int enemyTurnCount;

        public CombatScene(StateMachine stateMachine, List<Enemy> enemys) : base(stateMachine)
        {
            this.enemys = enemys;
            inventory = stateMachine.Player.Inventory;
            items = inventory.GetItems();
        }

        public override void Enter()
        {
            base.Enter();

            enemyTurnCount = 0;
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
        }

        protected override void Control()
        {
            Thread.Sleep(1000);
            stateMachine.ChangeState(new PlayerTurnScene(stateMachine, enemys));
        }

        protected void EnemyStats()
        {
            Console.ResetColor();
            EnemyNumbers();
            Console.WriteLine();
            EnemyNames();
            EnemyHps();
            EnemyAtks();
            EnemyDefs();
            Console.WriteLine();
        }

        protected void EnemyNumbers()
        {
            Console.WriteLine();
            for (int i = 0; i < enemys.Count; i++)
            {
                Console.Write($"\t {i+1}번 \t\t");
            }
        }

        protected void EnemyNames()
        {
            Console.WriteLine();
            foreach (Enemy enemy in enemys)
            {
                Console.Write($"{enemy.Name} ( Lv.{enemy.Stat.Lv} ) \t");
            }
        }

        protected void EnemyHps()
        {
            Console.WriteLine();
            foreach (Enemy enemy in enemys)
            {
                Console.Write($"체 력 \t: {enemy.Stat.Hp} / {enemy.Stat.MaxHp} \t");
            }
        }

        protected void EnemyAtks()
        {
            Console.WriteLine();
            foreach (Enemy enemy in enemys)
            {
                Console.Write($"공격력 \t: {enemy.Stat.Atk} \t\t");
            }
        }

        protected void EnemyDefs()
        {
            Console.WriteLine();
            foreach (Enemy enemy in enemys)
            {
                Console.Write($"방어력 \t: {enemy.Stat.Def} \t\t");
            }
        }
    }
}
