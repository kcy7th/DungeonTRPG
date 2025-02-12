using DungeonTRPG.Entity.Enemy;
using DungeonTRPG.Entity.Utility;
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
            { 8000, new Enemy("슬라임", 50, new Stat(1, 10, 10, 0, 5, 0)) },
            { 8001, new Enemy("박쥐", 70, new Stat(1, 10, 16, 0, 5, 1),new List<int>(){9500}) },
            { 8002, new Enemy("고블린", 100, new Stat(2, 20, 20, 7, 9, 2),new List<int>(){9501}) },
            { 8003, new Enemy("스켈레톤", 150, new Stat(2, 30, 30, 7, 12, 3),new List<int>(){9502 }) },
            { 8004, new Enemy("오크", 175, new Stat(2, 35, 30, 11, 13, 3), new List<int>(){9503}) },
            { 8005, new Enemy("골렘", 200, new Stat(3, 40, 30, 15, 15, 3),new List<int>(){9504}) },
            { 8006, new Enemy("마녀", 500, new Stat(4, 50, 80, 30, 25, 10),new List<int>(){9505}) },
            { 8007, new Enemy("오우거", 700, new Stat(4, 50, 100, 22, 20, 15),new List<int>(){9506}) },
            { 8009, new Enemy("드래곤", 1000, new Stat(6, 100, 120, 30, 35, 20),new List<int>(){9507}) },

            //강화 (일반 몬스터의 1.5배(마나 제외, 소수점 내림), 레벨의 경우 2배 더 높게)
            { 8010, new Enemy("빨간 슬라임", 75, new Stat(2, 15, 20, 0, 10, 0)) },
            { 8011, new Enemy("어두운 박쥐", 105, new Stat(2, 20, 24, 0, 10, 1),new List<int>(){9500}) },
            { 8012, new Enemy("수상한 고블린", 150, new Stat(4, 30, 30, 7, 13, 3),new List<int>(){9501}) },
            { 8013, new Enemy("강한 스켈레톤", 225, new Stat(4, 45, 45, 7, 18, 4),new List<int>(){9502}) },
            { 8014, new Enemy("난폭한 오크", 262, new Stat(5, 52, 45, 11, 19, 4), new List<int>(){9503}) },
            { 8015, new Enemy("묵직한 골렘", 300, new Stat(6, 60, 45, 15, 22, 4),new List<int>(){9504}) },
            { 8016, new Enemy("괴상한 마녀", 750, new Stat(8, 75, 120, 30, 37, 15),new List<int>(){9505}) },
            { 8017, new Enemy("거대한 오우거", 1050, new Stat(8, 75, 150, 22, 30, 22),new List<int>(){9506}) },
            { 8019, new Enemy("검은 드래곤", 1500, new Stat(12, 150, 180, 30, 52, 30),new List<int>(){9507}) },

            //최종 (강화 몬스터의 1.5배(마나 제외, 소수점 내림), 레벨의 경우 2배 더 높게, 강화 스킬 보유)
            { 8020, new Enemy("섬뜩한 슬라임", 112, new Stat(4, 22, 30, 0, 15, 0)) },
            { 8021, new Enemy("섬뜩한 박쥐", 157, new Stat(4, 30, 36, 0, 15, 1),new List<int>(){9600}) },
            { 8022, new Enemy("섬뜩한 고블린", 225, new Stat(8, 45, 45, 7, 19, 4),new List<int>(){9601}) },
            { 8023, new Enemy("섬뜩한 스켈레톤", 337, new Stat(8, 67, 67, 7, 27, 6),new List<int>(){9602}) },
            { 8024, new Enemy("섬뜩한 오크", 437, new Stat(10, 75, 75, 11, 28, 6), new List<int>(){9603}) },
            { 8025, new Enemy("섬뜩한 골렘", 450, new Stat(12, 90, 67, 15, 33, 6),new List<int>(){9604}) },
            { 8026, new Enemy("섬뜩한 마녀", 1125, new Stat(16, 112, 180, 30, 55, 22),new List<int>(){9605}) },
            { 8027, new Enemy("섬뜩한 오우거", 1575, new Stat(16, 112, 225, 22, 45, 33),new List<int>(){9606}) },
            { 8029, new Enemy("섬뜩한 드래곤", 2250, new Stat(24, 225, 270, 30, 78, 45),new List<int>(){9607}) },

            //보스 몬스터 (최종 몬스터의 2.5배(마나 제외, 소수점 내림), 레벨의 경우 3배 더 높게, 특수 스킬 보유)
            { 8100, new Enemy("거대 슬라임", 280, new Stat(12, 55, 75, 0, 37, 0)) },
            { 8101, new Enemy("흉폭한 박쥐", 392, new Stat(12, 75, 90, 0, 37, 2), new List<int>(){9600}) },
            { 8102, new Enemy("야만적인 고블린+", 562, new Stat(24, 112, 112, 7, 47, 10), new List<int>(){9601}) },
            { 8103, new Enemy("스켈레톤 군주", 842, new Stat(24, 167, 167, 7, 67, 15), new List<int>(){9602}) },
            { 8104, new Enemy("오크 군주", 984, new Stat(30, 196, 187, 11, 52, 12), new List<int>(){9603}) },
            { 8105, new Enemy("고대 골렘", 1125, new Stat(36, 225, 167, 15, 82, 15), new List<int>(){9604}) },
            { 8106, new Enemy("원시 마녀", 2812, new Stat(48, 280, 450, 30, 137, 55), new List<int>(){9605}) },
            { 8107, new Enemy("거대 오우거", 3937, new Stat(48, 280, 562, 22, 112, 82), new List<int>(){9606}) },
            { 8109, new Enemy("블랙 드래곤", 5625, new Stat(72, 562, 675, 30, 195, 112), new List<int>(){9607}) },

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
