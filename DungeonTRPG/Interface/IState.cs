namespace DungeonTRPG.Interface
{
    internal interface IState
    {
        void Enter();
        void Exit();
        void Update();
    }
}
