using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Player;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Interface;
using DungeonTRPG.StateMachineSystem.SceneStates.Combat;
using DungeonTRPG.StateMachineSystem.SceneStates.Dungeon;
using DungeonTRPG.StateMachineSystem.SceneStates.Player;
using DungeonTRPG.StateMachineSystem.SceneStates.Village;
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
        internal bool isCombat { get; set; } = false;
        internal bool isGameOver { get; set; } = false;

        internal DungeonScene DungeonScene { get; }
        internal INNScene InnScene { get; }
        internal ShopScene ShopScene { get; }
        internal InventoryScene InventoryScene { get; }
        internal EquipmentScene EquipmentScene { get; }
        internal ItemUseScene ItemUseScene { get; }
        internal StateScene StateScene { get; }
        internal RestRoomScene RestRoomScene { get; }
        internal SecretShopScene SecretShopScene { get; }
        internal SecretBoxScene SecretBoxScene { get; }
        internal EnemyFindScene EnemyFindScene { get; }
        internal CombatScene CombatScene { get; }
        internal PlayerTurnScene PlayerTurnScene { get; }


        internal StateMachine(Player player)
        {
            Player = player;

            DungeonScene = new DungeonScene(this);
            InnScene = new INNScene(this);
            ShopScene = new ShopScene(this);
            InventoryScene = new InventoryScene(this);
            EquipmentScene = new EquipmentScene(this);
            StateScene = new StateScene(this);
            RestRoomScene = new RestRoomScene(this);
            SecretShopScene = new SecretShopScene(this);
            EnemyFindScene = new EnemyFindScene(this);
            SecretBoxScene = new SecretBoxScene(this);
            ItemUseScene = new ItemUseScene(this);
            CombatScene = new CombatScene(this);
            PlayerTurnScene = new PlayerTurnScene(this);
        }

        internal void ChangeState(IState state)
        {
            currentState?.Exit();

            if (currentState != null) preStates.Push(currentState);
            currentState = state;

            currentState?.Enter();
        }

        public void PreStateDataClear()
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
