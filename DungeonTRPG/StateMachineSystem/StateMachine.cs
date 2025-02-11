using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Player;
using DungeonTRPG.Interface;
using DungeonTRPG.StateMachineSystem.SceneStates.Combat;
using DungeonTRPG.StateMachineSystem.SceneStates.Dungeon;
using DungeonTRPG.StateMachineSystem.SceneStates.PlayerScene;
using DungeonTRPG.StateMachineSystem.SceneStates.Village;

namespace DungeonTRPG.StateMachineSystem
{
    internal class StateMachine
    {
        private IState currentState;
        private Stack<IState> preStates = new Stack<IState>();

        internal CombatScene preCombatScene;
        internal List<Enemy> enemys = new List<Enemy>();
        internal int enemyTurnCount = 0;

        internal Player Player { get; }
        internal Enemy Enemy { get; set; }
        internal int ExploredCount { get; set; }
        internal int currentFloor { get; set; }
        internal bool isGameOver { get; set; } = false;

        internal VillageScene VillageScene { get; }
        internal DungeonScene DungeonScene { get; }
        internal INNScene InnScene { get; }
        internal ShopScene ShopScene { get; }
        internal InventoryScene InventoryScene { get; }
        internal CreatePlayerScene CreatePlayerScene { get; }
        internal EquipmentScene EquipmentScene { get; }
        internal ItemUseScene ItemUseScene { get; }
        internal StateScene StateScene { get; }
        internal RestRoomScene RestRoomScene { get; }
        internal SecretShopScene SecretShopScene { get; }
        internal SecretBoxScene SecretBoxScene { get; }
        internal EnemyFindScene EnemyFindScene { get; }


        internal StateMachine(Player player)
        {
            Player = player;

            VillageScene = new VillageScene(this);
            DungeonScene = new DungeonScene(this);
            InnScene = new INNScene(this);
            ShopScene = new ShopScene(this);
            InventoryScene = new InventoryScene(this);
            CreatePlayerScene = new CreatePlayerScene(this);
            EquipmentScene = new EquipmentScene(this);
            StateScene = new StateScene(this);
            RestRoomScene = new RestRoomScene(this);
            SecretShopScene = new SecretShopScene(this);
            EnemyFindScene = new EnemyFindScene(this);
            SecretBoxScene = new SecretBoxScene(this);
            ItemUseScene = new ItemUseScene(this);
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
