using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.EntitySystem;
using DungeonTRPG.Items;
using DungeonTRPG.StateMachineSystem;
using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace DungeonTRPG.Manager.Data
{
    internal class EnemyDB
    {
        [JsonProperty]
        public Dictionary<int, Enemy> enemys { get; } = new Dictionary<int, Enemy>()
        {
            //일반 (level, exp, maxHp, maxMp, atk, def)
            { 8001, new Enemy("박쥐", 70, new Stat(1, 10, 16, 0, 5, 0, 1),new List<int>(){9500}) },

        };

        public Enemy GetByKey(int key)
        {
            if (enemys.ContainsKey(key))
            {
                return enemys[key];
            }
            return null;
        }
    }
}
