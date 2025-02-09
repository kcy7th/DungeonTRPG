using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Player;
using DungeonTRPG.Interface;
using DungeonTRPG.StateMachineSystem.SceneStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.StateMachineSystem
{
    internal class StateMachine
    {
        private IState currentState;
        private Stack<IState> preStates = new Stack<IState>();

        internal Player Player { get; }
        internal Enemy Enemy { get; set; }
        internal int ExploredCount { get; set; }
        internal int currentFloor { get; set; }
        internal bool isGameOver { get; set; } = false;

        internal DungeonScene DungeonScene { get; }
        internal INNScene InnScene { get; }
        internal ShopScene ShopScene { get; }
        internal InventoryScene InventoryScene { get; }
        internal StateScene StateScene { get; }
        internal RestRoomScene RestRoomScene { get; }
        internal SecretShopScene SecretShopScene { get; }
        internal FightScene FightScene { get; }



        internal StateMachine(Player player)
        {
            Player = player;

            DungeonScene = new DungeonScene(this);
            InnScene = new INNScene(this);
            ShopScene = new ShopScene(this);
            InventoryScene = new InventoryScene(this);
            StateScene = new StateScene(this);
            RestRoomScene = new RestRoomScene(this);
            SecretShopScene = new SecretShopScene(this);
            FightScene = new FightScene(this);
        }

        internal void ChangeState(IState state)
        {
            currentState?.Exit();

            if (currentState != null) preStates.Push(currentState);
            currentState = state;

            currentState?.Enter();
        }

        public void PreviousDataClear()
        {
            if (preStates.Count > 0)
            {
                IState state = preStates.Pop();
                preStates.Clear();
                preStates.Push(state);
            }
        }

        public void GoPreviousState()
        {
            currentState?.Exit();

            currentState = preStates.Pop();

            currentState?.Enter();
        }

        public void Update()
        {
            currentState?.Update();
        }
    }
}
