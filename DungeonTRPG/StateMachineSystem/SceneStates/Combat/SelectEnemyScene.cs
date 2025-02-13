using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.Items;
using DungeonTRPG.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class SelectEnemyScene : CombatScene
    {
        public SelectEnemyScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            foreach (Enemy enemy in stateMachine.enemys)
            {
                enemy.OnCharacterDie += CharacterDead;
            }

            player.OnCharacterDie += CharacterDead;
        }

        public override void Exit()
        {
            base.Exit();

            foreach (Enemy enemy in stateMachine.enemys)
            {
                enemy.OnCharacterDie -= CharacterDead;
            }

            player.OnCharacterDie -= CharacterDead;
        }

        protected override void View()
        {
            EnemyStats();

            Console.WriteLine("\n0. 돌아가기");
            Console.WriteLine();
            var cursurPos = InputField("공격하고 싶은 적의 번호를 입력해주세요.");

            PlayerStats();

            Console.SetCursorPosition(cursurPos.Left, cursurPos.Top);
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num == 0) stateMachine.GoPreviousState();

                else if (0 < num && num <= stateMachine.enemys.Count)
                {
                    Enemy enemy = stateMachine.enemys[num - 1];
                    if (enemy.Stat.Hp > 0)
                    {
                        if (stateMachine.preCombatScene is PlayerTurnScene)
                        {
                            int damage = player.Attack(enemy);
                            Attack(player, enemy, damage);
                        }
                        else if (stateMachine.preCombatScene is CombatSkillScene)
                        {
                            CombatSkillScene combatSkill = stateMachine.preCombatScene as CombatSkillScene;
                            int key = player.Skills[combatSkill.selectSkill];
                            Skill skill = GameManager.Instance.DataManager.GameData.SkillDB.GetByKey(key);
                            UseSkill(enemy, skill.name);
                            int damage = skill.UseSkill(player, new List<Character>() { enemy });
                            if (damage > 0) Damage(enemy, damage);
                        }
                        else if (stateMachine.preCombatScene is CombatItemScene)
                        {
                            CombatItemScene combatItem = stateMachine.preCombatScene as CombatItemScene;
                            player.Inventory.ItemUse(combatItem.selectItem, player, new List<Character>() { enemy });
                        }

                        stateMachine.ChangeState(new EnemyTurnScene(stateMachine));
                    }
                    else SendMessage("이미 죽어 있습니다.");
                }
                else SendMessage("잘못된 입력입니다.");
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
