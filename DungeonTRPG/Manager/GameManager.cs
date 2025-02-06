using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Manager
{
    internal class GameManager
    {
        private static GameManager _instance;
        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameManager();
                    _instance.Init();
                }
                return _instance;
            }
        }

        public DataManager DataManager { get; private set; }

        private void Init()
        {
            DataManager = new DataManager();
        }
    }
}
