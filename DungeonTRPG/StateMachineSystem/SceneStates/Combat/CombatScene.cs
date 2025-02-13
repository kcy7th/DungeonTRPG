using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.Manager;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class CombatScene : SceneState
    {
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

        }

        protected override void Control()
        {
            stateMachine.ChangeState(new PlayerTurnScene(stateMachine));
        }

        protected void PlayerStats()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"{player.Name}(Lv.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(player.Stat.Lv);
            Console.ResetColor();
            Console.Write(")");

            Console.Write($" [ Exp : ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(player.Stat.Exp);
            Console.ResetColor();
            Console.Write(" / ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(player.Stat.MaxExp);
            Console.ResetColor();
            Console.WriteLine(" ]");
            Console.ResetColor();

            Console.Write($"상 태 \t: ");
            Console.WriteLine(player.CharacterState.State);

            Console.Write($"체 력 \t: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(player.Stat.Hp);
            Console.ResetColor();
            Console.Write($" / ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(player.Stat.MaxHp);
            Console.ResetColor();
            if (player.Inventory.GetTotalEquipHp() != 0)
            {
                Console.Write(" (");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"+{player.Inventory.GetTotalEquipHp()}");
                Console.ResetColor();
                Console.Write(")");
            }
            Console.WriteLine();

            Console.Write($"마 나 \t: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(player.Stat.Mp);
            Console.ResetColor();
            Console.Write($" / ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(player.Stat.MaxMp);
            Console.ResetColor();
            if (player.Inventory.GetTotalEquipMp() != 0)
            {
                Console.Write(" (");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"+{player.Inventory.GetTotalEquipMp()}");
                Console.ResetColor();
                Console.Write(")");
            }
            Console.WriteLine();

            Console.Write($"공격력 \t: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(player.Stat.Atk);
            Console.ResetColor();
            if (player.Inventory.GetTotalEquipAtk() != 0)
            {
                Console.Write(" (");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"+{player.Inventory.GetTotalEquipAtk()}");
                Console.ResetColor();
                Console.Write(")");
            }
            Console.WriteLine();

            Console.Write($"주문력 \t: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(player.Stat.SpellAtk);
            Console.ResetColor();
            if (player.Inventory.GetTotalEquipSpellAtk() != 0)
            {
                Console.Write(" (");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"+{player.Inventory.GetTotalEquipSpellAtk()}");
                Console.ResetColor();
                Console.Write(")");
            }
            Console.WriteLine();

            Console.Write($"방어력 \t: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(player.Stat.Def);
            Console.ResetColor();
            if (player.Inventory.GetTotalEquipDef() != 0)
            {
                Console.Write(" (");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"+{player.Inventory.GetTotalEquipDef()}");
                Console.ResetColor();
                Console.Write(")");
            }
            Console.WriteLine();
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
            for (int i = 0; i < stateMachine.enemys.Count; i++)
            {
                Console.Write($"\t {i+1}번 \t\t\t");
            }
        }

        protected void EnemyNames()
        {
            if (stateMachine.enemys.Count < 1) return;

            Console.WriteLine();
            foreach (Enemy enemy in stateMachine.enemys)
            {
                if(enemy == null) continue;

                Console.Write($"{enemy.Name}(Lv.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(enemy.Stat.Lv);
                Console.ResetColor();
                Console.Write(")");
                for(int i = 0; i <= 4 / enemy.Name.Length; i++)
                {
                    Console.Write("\t");
                }
                if(enemy.Name.Length > 2) Console.Write("\t");
            }
        }

        protected void EnemyStates()
        {
            Console.WriteLine();
            foreach (Enemy enemy in stateMachine.enemys)
            {
                if(enemy.Stat.Hp > 0) Console.Write($"상 태 \t: {enemy.CharacterState.State}   \t\t");
                else Console.Write("\t\t\t\t");
            }
        }

        protected void EnemyHps()
        {
            Console.WriteLine();
            foreach (Enemy enemy in stateMachine.enemys)
            {
                if (enemy.Stat.Hp > 0)
                {
                    Console.Write($"체 력 \t: ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(enemy.Stat.Hp);
                    Console.ResetColor();
                    Console.Write($" / ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(enemy.Stat.MaxHp);
                    Console.Write("\t\t");
                    Console.ResetColor();
                }
                else Console.Write("\t\t\t\t");
            }
        }

        protected void EnemyMps()
        {
            Console.WriteLine();
            foreach (Enemy enemy in stateMachine.enemys)
            {
                if (enemy.Stat.Hp > 0)
                {
                    Console.Write($"마 나 \t: ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(enemy.Stat.Mp);
                    Console.ResetColor();
                    Console.Write($" / ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(enemy.Stat.MaxMp);
                    Console.Write("\t\t");
                    Console.ResetColor();
                }
                else Console.Write("\tDead\t\t\t");
            }
        }

        protected void EnemyAtks()
        {
            Console.WriteLine();
            foreach (Enemy enemy in stateMachine.enemys)
            {
                if (enemy.Stat.Hp > 0)
                {
                    Console.Write($"공격력 \t: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(enemy.Stat.Atk);
                    Console.Write("\t\t\t");
                    Console.ResetColor();
                }
                else Console.Write("\t\t\t\t");
            }
        }

        protected void EnemyDefs()
        {
            Console.WriteLine();
            foreach (Enemy enemy in stateMachine.enemys)
            {
                if (enemy.Stat.Hp > 0)
                {
                    Console.Write($"방어력 \t: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(enemy.Stat.Def);
                    Console.Write("\t\t\t");
                    Console.ResetColor();
                }
                else Console.Write("\t\t\t\t");
            }
        }

        protected void CharacterDead(Character target)
        {
            if (target == player)
            {
                stateMachine.ChangeState(new PlayerDefeatScene(stateMachine));
                return;
            }
        }

        protected void Attack(Character caster, Character target, int damage)
        {
            BlinkingEffect();

            Console.WriteLine("\n" +
                $"{caster.Name} 의 공격! \n" +
                $"Lv.{target.Stat.Lv} {target.Name} 을(를) 맞췄습니다. [데미지 : {damage}]");

            Thread.Sleep(stateMachine.tick);
        }

        protected void Damage(Character target, int damage)
        {
            BlinkingEffect();

            Console.WriteLine("\n" +
                $"Lv.{target.Stat.Lv} {target.Name} 이(가) 데미지를 받았습니다. [데미지 : {damage}]");

            Thread.Sleep(stateMachine.tick);
        }

        protected void SplashDamage(List<Character> targets, int damage)
        {
            BlinkingEffect();

            for (int i = 0; i < targets.Count; i++)
            {
                Console.WriteLine("\n" +
                $"Lv.{targets[i].Stat.Lv} {targets[i].Name} 이(가) 데미지를 받았습니다. [데미지 : {damage}]");
            }

            Thread.Sleep(stateMachine.tick);
        }

        protected void UseSkill(Character target, string skillName)
        {
            BlinkingEffect();

            Console.WriteLine("\n" +
                $"Lv.{target.Stat.Lv} {target.Name} 이(가) {skillName} 을(를) 시전 하였습니다.");

            Thread.Sleep(stateMachine.tick);
        }

        protected override void Heal(Character target, int healHp, int healMp)
        {
            Console.Clear();

            EnemyStats();
            PlayerStats();

            base.Heal(target, healHp, healMp);
        }

        private void BlinkingEffect()
        {
            Console.Clear();
            EnemyStats();
            PlayerStats();
            Thread.Sleep(50);
            Console.Clear();
            Thread.Sleep(50);
            EnemyStats();
            PlayerStats();
            Thread.Sleep(50);
            Console.Clear();
            Thread.Sleep(50);
            EnemyStats();
            PlayerStats();
            Thread.Sleep(50);
            Console.Clear();
            Thread.Sleep(50);
            EnemyStats();
            PlayerStats();
        }

        protected void Sleep(Character target)
        {
            Console.Clear();

            EnemyStats();

            Console.WriteLine("\n" +
                $"Lv. {target.Stat.Lv} {target.Name} 이(가) 자고 있습니다.");

            Thread.Sleep(stateMachine.tick);
        }

        protected void Addiction(Character target)
        {
            string message = "";

            switch (target.CharacterState.State)
            {
                case State.Burn:
                    message = "화상에 걸려 있습니다.";
                    break;
                case State.Poison:
                    message = "독에 걸려 있습니다.";
                    break;
            }

            Console.Clear();

            EnemyStats();

            Console.WriteLine("\n" +
                $"Lv. {target.Stat.Lv} {target.Name} 이(가) {message}");

            Thread.Sleep(stateMachine.tick);
        }
        protected void Confusion(Character target)
        {
            Console.Clear();

            EnemyStats();

            Console.WriteLine("\n" +
                $"Lv. {target.Stat.Lv} {target.Name} 이(가) 혼란에 빠져 있습니다.");

            Thread.Sleep(stateMachine.tick);
        }
    }
}
