using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.Manager.Data
{
    internal class EnemyDB
    {
        [JsonProperty]
        public Dictionary<int, Enemy> enemys { get; } = new Dictionary<int, Enemy>()
        {
            // (level, exp, maxHp, maxMp, atk, def)
            { 8000, new Enemy("슬라임", 50,          new Stat(1, 10, 10, 0, 5, 0)) },
            { 8001, new Enemy("박쥐", 70,            new Stat(1, 10, 16, 0, 5, 1)) },
            { 8002, new Enemy("고블린", 100,         new Stat(2, 20, 20, 5, 9, 2)) },
            { 8003, new Enemy("스켈레톤", 150,       new Stat(2, 30, 30, 5, 12, 3)) },
            { 8004, new Enemy("골렘", 200,           new Stat(3, 40, 30, 10, 15, 3)) },
            { 8005, new Enemy("마녀", 500,           new Stat(4, 50, 80, 20, 25, 10)) },
            { 8006, new Enemy("오우거", 700,         new Stat(4, 50, 100, 15, 20, 15)) },
            { 8007, new Enemy("드래곤", 1000,        new Stat(6, 100, 120, 20, 35, 20)) }
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
