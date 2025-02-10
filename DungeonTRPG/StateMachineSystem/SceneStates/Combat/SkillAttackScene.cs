using DungeonTRPG.Entity.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class SkillAttackScene : CombatScene
    {
        private int index;

        public SkillAttackScene(StateMachine stateMachine, List<Enemy> enemys, int index) : base(stateMachine, enemys)
        {
            this.index = index;
        }

        protected override void View()
        {
            base.View();

            CombatSkillScene combatSkill = stateMachine.preCombatScene as CombatSkillScene;
            inventory.Character.Skills[combatSkill.selectSkill].UseSkill(null, enemys[index]);

            Console.Clear();

            EnemyStats();
            Thread.Sleep(5000);
        }

        protected override void Control()
        {
            
        }
    }
}
