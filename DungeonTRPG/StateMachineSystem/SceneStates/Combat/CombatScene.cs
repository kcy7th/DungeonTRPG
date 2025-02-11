using DungeonTRPG.Entity;
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

        public CombatScene(StateMachine stateMachine, List<Enemy> enemys) : base(stateMachine)
        {
            this.enemys = enemys;
            inventory = stateMachine.Player.Inventory;
            items = inventory.GetItems();
        }

        public override void Enter()
        {
            base.Enter();

            foreach (Enemy enemy in enemys)
            {
                enemy.OnAttack += Attack;
                enemy.OnDamage += Damage;
                enemy.OnHeal += Heal;
                enemy.Stat.CharacterDie += 
            }

            player.OnAttack += Attack;
            player.OnDamage += Damage;
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Exit()
        {
            base.Exit();

            foreach (Enemy enemy in enemys)
            {
                enemy.OnAttack -= Attack;
                enemy.OnDamage -= Damage;
                enemy.OnHeal -= Heal;
            }

            player.OnAttack -= Attack;
            player.OnDamage -= Damage;
        }

        protected override void View()
        {
            EnemyStats();
            PlayerStats();
        }

        protected override void Control()
        {
            Thread.Sleep(1000);
            stateMachine.ChangeState(new PlayerTurnScene(stateMachine, enemys));
        }

        protected void PlayerStats()
        {
            Console.WriteLine(
                $"\n" +
                $"{player.Name} ( Lv.{player.Stat.Lv} ) \n" +
                $"상 태 \t: {player.CharacterState.State} \n" +
                $"체 력 \t: {player.Stat.Hp} / {player.Stat.MaxHp} \n" +
                $"마 나 \t: {player.Stat.Mp} / {player.Stat.MaxMp} \n" +
                $"공격력 \t: {player.Stat.Atk} \n" +
                $"방어력 \t: {player.Stat.Def}");
        }

        protected void EnemyStats()
        {
            Console.ResetColor();
            EnemyNumbers();
            Console.WriteLine();
            EnemyNames();
            EnemyStates();
            EnemyHps();
            EnemyMps();
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

        protected void EnemyStates()
        {
            Console.WriteLine();
            foreach (Enemy enemy in enemys)
            {
                Console.Write($"상 태 \t: {enemy.CharacterState.State} \t\t");
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

        protected void EnemyMps()
        {
            Console.WriteLine();
            foreach (Enemy enemy in enemys)
            {
                Console.Write($"마 나 \t: {enemy.Stat.Mp} / {enemy.Stat.MaxMp} \t");
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

        private void CharacterDie()
        {

        }

        private void Attack(Character caster, Character target, int damage)
        {
            BlinkingEffect();

            Console.WriteLine("\n" +
                $"{caster.Name} 의 공격! \n" +
                $"{target.Stat.Lv} {target.Name} 을(를) 맞췄습니다. [데미지 : {damage}]");

            Thread.Sleep(1000);
        }

        private void Damage(Character target, int damage)
        {
            BlinkingEffect();

            Console.WriteLine("\n" +
                $"{target.Stat.Lv} {target.Name} 이(가) 데미지를 받았습니다. [데미지 : {damage}]");

            Thread.Sleep(1000);
        }

        private void BlinkingEffect()
        {
            Console.Clear();
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

        protected void Sleep(Character target)
        {
            EnemyStats();

            Console.WriteLine("\n" +
                $"{target.Stat.Lv} {target.Name} 이(가) 데미지를 자고 있습니다.");

            Thread.Sleep(1000);
        }

        protected void Addiction(Character target)
        {
            EnemyStats();

            Console.WriteLine("\n" +
                $"{target.Stat.Lv} {target.Name} 이(가) 독에 걸려 있습니다.");

            Thread.Sleep(1000);
        }

        protected void Confusion(Character target)
        {
            EnemyStats();

            Console.WriteLine("\n" +
                $"{target.Stat.Lv} {target.Name} 이(가) 혼란에 빠져 있습니다.");

            Thread.Sleep(1000);
        }
    }
}
