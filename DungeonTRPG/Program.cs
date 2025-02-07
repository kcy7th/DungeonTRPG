using DungeonTRPG.Entity.Player;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.StateMachineSystem;
using DungeonTRPG.StateMachineSystem.SceneStates;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StateMachine machine = new StateMachine(new Player("Player", 1500, new Stat(1, 1, 1, 1, 1, 1, 1, 1), Job.Warrior));

            machine.ChangeState(new VillageScene(machine));

            while (!machine.isGameOver)
            {
                machine.Update();
            }
        }
    }
}
