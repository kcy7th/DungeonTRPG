using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.EntitySystem.Utility
{
    internal class CharacterState
    {
        public State State { get; private set; } = State.None;
        public int RemainingTurn { get; private set; } = 0;

        public void SetState(State state)
        {
            if (State != State.None) return;
            
            State = state;
        }

        public void TurnCountDown()
        {
            if (RemainingTurn > 0)
            {
                RemainingTurn--;
                State = State.None;
            }
        }
    }
}