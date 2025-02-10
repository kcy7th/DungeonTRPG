using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class CombatScene : SceneState
    {
        protected Enemy enemy;
        protected Inventory inventory;
        protected List<Item> items;

        public CombatScene(StateMachine stateMachine) : base(stateMachine)
        {
            inventory = stateMachine.Player.Inventory;
            items = inventory.GetItems();
        }

        public override void Enter()
        {
            base.Enter();

            enemy = new Enemy("고블린", 10, new Stat(1, 10, 10, 10, 1, 1));
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{enemy.Name}이(가) 등장 하였다!");

            EnemyStat();
        }

        protected override void Control()
        {
            Thread.Sleep(1000);
            stateMachine.ChangeState(stateMachine.PlayerTurnScene);
        }

        protected void EnemyStat()
        {
            Console.ResetColor();
            Console.WriteLine(
                $"\n" +
                $"{enemy.Name} ( Lv.{enemy.Stat.Lv} ) \n" +
                $"체 력 \t: {enemy.Stat.Hp} / {enemy.Stat.MaxHp} \n" +
                $"공격력 \t: {enemy.Stat.Atk} \n" +
                $"방어력 \t: {enemy.Stat.Def} \n");
        }
    }
}
