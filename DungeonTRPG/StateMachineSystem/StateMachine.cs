using DungeonTRPG.EntitySystem;
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
        internal int enemyTurnCount = 9;

        internal int exploredCount = 0;
        internal int currentFloor = 1;
        internal bool isGameOver = false;

        public event Action OnFloorMultiplesTen;

        private Player player;
        public Player Player => player;
        internal Enemy Enemy { get; set; }

        internal VillageScene VillageScene { get; private set; }
        internal DungeonScene DungeonScene { get; private set; }
        internal INNScene InnScene { get; private set; }
        internal ShopScene ShopScene { get; private set; }
        internal BuyScene BuyScene { get; private set; }
        internal InventoryScene InventoryScene { get; private set; }
        internal CreatePlayerScene CreatePlayerScene { get; private set; }
        internal EquipmentScene EquipmentScene { get; private set; }
        internal ItemUseScene ItemUseScene { get; private set; }
        internal StateScene StateScene { get; private set; }
        internal RestRoomScene RestRoomScene { get; private set; }
        internal SecretShopScene SecretShopScene { get; private set; }
        internal SecretBoxScene SecretBoxScene { get; private set; }
        internal EnemyFindScene EnemyFindScene { get; private set; }

        public void Init(Player player)
        {
            this.player = player;

            VillageScene = new VillageScene(this);
            DungeonScene = new DungeonScene(this);
            InnScene = new INNScene(this);
            ShopScene = new ShopScene(this);
            BuyScene = new BuyScene(this);
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
            if (currentFloor % 10 == 0) OnFloorMultiplesTen?.Invoke();
        }
    }
}
