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
            { 8000, new Enemy("슬라임", 70, new Stat(3, 1, 80, 30, 8, 8, 4), new List<int>(){ }) },
            { 8001, new Enemy("거미", 70, new Stat(6, 1, 100, 40, 11, 11, 6), new List<int>(){ }) },
            { 8002, new Enemy("버섯", 70, new Stat(9, 1, 120, 50, 14, 14, 8), new List<int>(){ }) },
            
            { 8003, new Enemy("화난 슬라임", 70, new Stat(12, 1, 140, 60, 17, 17, 10), new List<int>(){ }) },
            { 8004, new Enemy("독거미", 70, new Stat(15, 1, 160, 70, 20, 20, 12), new List<int>(){ }) },
            { 8005, new Enemy("뿔버섯", 70, new Stat(18, 1, 180, 80, 23, 23, 14), new List<int>(){ }) },
            
            { 8006, new Enemy("포이즌 슬라임", 70, new Stat(21, 1, 200, 90, 26, 26, 16), new List<int>(){ }) },
            { 8007, new Enemy("거대 거미", 70, new Stat(24, 1, 220, 100, 29, 29, 18), new List<int>(){ }) },
            { 8008, new Enemy("독버섯", 70, new Stat(27, 1, 240, 110, 32, 32, 20), new List<int>(){ }) },
            
            { 8009, new Enemy("10층 가디언", 70, new Stat(30, 1, 260, 120, 35, 35, 22), new List<int>(){ }) },
            
            // 11~20층 (초보자)
            { 8010, new Enemy("박쥐", 70, new Stat(33, 1, 280, 130, 38, 38, 24), new List<int>(){ }) },
            { 8011, new Enemy("뱀", 70, new Stat(36, 1, 300, 140, 41, 41, 26), new List<int>(){ }) },
            { 8012, new Enemy("멧돼지", 70, new Stat(39, 1, 320, 150, 44, 44, 28), new List<int>(){ }) },
            
            { 8013, new Enemy("흡혈 박쥐", 70, new Stat(42, 1, 340, 160, 47, 47, 30), new List<int>(){ }) },
            { 8014, new Enemy("코브라", 70, new Stat(45, 1, 360, 170, 50, 50, 32), new List<int>(){ }) },
            { 8015, new Enemy("화난 멧돼지", 70, new Stat(48, 1, 380, 180, 53, 53, 34), new List<int>(){ }) },
            
            { 8016, new Enemy("코로나 박쥐", 70, new Stat(51, 1, 400, 190, 56, 56, 36), new List<int>(){ }) },
            { 8017, new Enemy("아나콘다", 70, new Stat(54, 1, 420, 200, 59, 59, 38), new List<int>(){ }) },
            { 8018, new Enemy("거대한 멧돼지", 70, new Stat(57, 1, 440, 210, 62, 62, 40), new List<int>(){ }) },
            
            { 8019, new Enemy("20층 가디언", 70, new Stat(60, 1, 460, 220, 65, 65, 42), new List<int>(){ }) },
        };

        public Enemy GetByKey(int key)
        {
            if (enemys.ContainsKey(key))
            {
                return enemys[key].Clone() as Enemy;
            }
            return null;
        }
    }
}
