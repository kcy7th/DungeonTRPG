using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class SelectEnemyScene : CombatScene
    {
        public SelectEnemyScene(StateMachine stateMachine, List<Enemy> enemys) : base(stateMachine, enemys)
        {
        }

        protected override void View()
        {
            base.View();

            Console.WriteLine("\n0. 돌아가기");
            Console.Write("\n공격하고 싶은 적의 번호를 입력해주세요.\n>> ");
        }

        protected override void Control()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out var num))
            {
                if (num == 0) stateMachine.GoPreviousState();

                if (0 < num && num <= enemys.Count)
                {
                    if (stateMachine.preCombatScene is PlayerTurnScene) player.Attack(enemys[num - 1]);
                    else if (stateMachine.preCombatScene is CombatSkillScene)
                    {
                        CombatSkillScene combatSkill = stateMachine.preCombatScene as CombatSkillScene;
                        Skill skill = player.Skills[combatSkill.selectSkill];
                        skill.UseSkill(null, enemys[num - 1]);
                    }
                    else if (stateMachine.preCombatScene is CombatItemScene) { }

                    stateMachine.ChangeState(new EnemyTurnScene(stateMachine, enemys));
                }
            }
            else SendMessage("잘못된 입력입니다.");
        }
    }
}
