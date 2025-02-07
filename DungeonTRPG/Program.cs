using DungeonTRPG.Entity.Player;
using DungeonTRPG.StateMachineSystem;
using DungeonTRPG.StateMachineSystem.SceneStates;

namespace DungeonTRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StateMachine machine = new StateMachine(new Player());

            machine.ChangeState(new VillageScene(machine));

            while (!machine.isGameOver)
            {
                machine.Update();
            }
        }
    }
}
