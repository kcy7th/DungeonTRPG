using DungeonTRPG.EntitySystem;
using DungeonTRPG.StateMachineSystem.SceneStates.Dungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class PlayerWinScene : CombatScene
    {
        public PlayerWinScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        protected override void View()
        {
            int preLv = player.Stat.Lv;
            int preExp = player.Stat.Exp;
            int preGold = player.Gold;

            player.AddExp(CalculateExp());
            player.EarnGold(CalculateGold());

            Console.WriteLine("Victory");
            Console.WriteLine();
            Console.WriteLine($"던전에서 몬스터 {stateMachine.enemys.Count}마리를 잡았습니다.");
            Console.WriteLine();
            if (preLv < player.Stat.Lv) Console.WriteLine($"Lv.{preLv} -> {player.Stat.Lv}");
            Console.WriteLine($"Exp : {preExp} -> {player.Stat.Exp}");
            Console.WriteLine($"Gold : {preGold} -> {player.Gold}");
        }

        private int CalculateExp()
        {
            int totalExp = 0;
            foreach (Enemy enemy in stateMachine.enemys)
            {
                totalExp += enemy.Stat.MaxExp;
            }
            return totalExp;
        }

        private int CalculateGold()
        {
            int totalGold = 0;
            foreach (Enemy enemy in stateMachine.enemys)
            {
                totalGold += enemy.Gold;
            }
            return totalGold;
        }

        protected override void Control()
        {
            Thread.Sleep(1000);
            stateMachine.ChangeState(stateMachine.DungeonScene);
        }
    }
}
