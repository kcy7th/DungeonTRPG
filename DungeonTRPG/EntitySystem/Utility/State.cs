namespace DungeonTRPG.EntitySystem.Utility
{
    internal class State
    {
        public List<State> states = new List<State>();

        public State(List<State> states)
        {
            this.states = states;
        }
    }
}