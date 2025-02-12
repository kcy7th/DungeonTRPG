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
        public int Randomizer(int skilltoAdd)
        {
            Random random = new Random();
            if (GameManager.Instance.DataManager.GameData.SkillDB.Items.ContainsKey(skilltoAdd))
            {
                return random2;
            }

            return 0;
        }

        [JsonProperty]
        public Dictionary<int, Enemy> enemys { get; } = new Dictionary<int, Enemy>()
        {


            //1층 (level, exp, maxHp, maxMp, atk, def)
            { 8000, new Enemy("슬라임", 50, new Stat(1, 10, 10, 0, 5, 0)) },
            { 8001, new Enemy("박쥐", 70, new Stat(1, 10, 16, 0, 5, 1),new List<int>(){9500}) },
            { 8002, new Enemy("고블린", 100, new Stat(2, 20, 20, 7, 9, 2),new List<int>(){9501}) },
            { 8003, new Enemy("스켈레톤", 150, new Stat(2, 30, 30, 7, 12, 3),new List<int>(){9502 }) },
            { 8004, new Enemy("골렘", 200, new Stat(3, 40, 30, 15, 15, 3),new List<int>(){9503}) },
            { 8005, new Enemy("마녀", 500, new Stat(4, 50, 80, 30, 25, 10),new List<int>(){9504}) },
            { 8006, new Enemy("오우거", 700, new Stat(4, 50, 100, 22, 20, 15),new List<int>(){9505}) },
            { 8009, new Enemy("드래곤", 1000, new Stat(6, 100, 120, 30, 35, 20),new List<int>(){9506}) },

            //2층 강화 아종 (원본의 1.5배(마나 제외, 소수점 내림), 레벨의 경우 2배 더 높게)
            { 8010, new Enemy("빨간 슬라임", 75, new Stat(2, 15, 20, 0, 10, 0)) },
            { 8011, new Enemy("어두운 박쥐", 105, new Stat(2, 20, 24, 0, 10, 1),new List<int>(){9500}) },
            { 8012, new Enemy("수상한 고블린", 150, new Stat(4, 30, 30, 7, 13, 3),new List<int>(){9501}) },
            { 8013, new Enemy("강한 스켈레톤", 225, new Stat(4, 45, 45, 7, 18, 4),new List<int>(){9502}) },
            { 8014, new Enemy("묵직한 골렘", 300, new Stat(6, 60, 45, 15, 22, 4),new List<int>(){9503}) },
            { 8015, new Enemy("괴상한 마녀", 750, new Stat(8, 75, 120, 30, 37, 15),new List<int>(){9504}) },
            { 8016, new Enemy("거대한 오우거", 1050, new Stat(8, 75, 150, 22, 30, 22),new List<int>(){9505}) },
            { 8019, new Enemy("검은 드래곤", 1500, new Stat(12, 150, 180, 30, 52, 30),new List<int>(){9506}) },

            //3층 강화 아종 (2층 몬스터들의 1.5배(마나 제외, 소수점 내림), 레벨의 경우 2배 더 높게, 강화 스킬 보유)
            { 9010, new Enemy("섬뜩한 슬라임", 112, new Stat(4, 22, 30, 0, 15, 0)) },
            { 9011, new Enemy("섬뜩한 박쥐", 157, new Stat(4, 30, 36, 0, 15, 1),new List<int>(){9500}) },
            { 9012, new Enemy("섬뜩한 고블린", 225, new Stat(8, 45, 45, 7, 19, 4),new List<int>(){9501}) },
            { 9013, new Enemy("섬뜩한 스켈레톤", 337, new Stat(8, 67, 67, 7, 27, 6),new List<int>(){9502}) },
            { 9014, new Enemy("섬뜩한 골렘", 450, new Stat(12, 90, 67, 15, 15, 6),new List<int>(){9503}) },
            { 9015, new Enemy("섬뜩한 마녀", 1125, new Stat(16, 112, 180, 30, 55, 22),new List<int>(){9504}) },
            { 9016, new Enemy("섬뜩한 오우거", 1575, new Stat(16, 112, 225, 22, 45, 33),new List<int>(){9505}) },
            { 9019, new Enemy("섬뜩한 드래곤", 2250, new Stat(24, 225, 270, 30, 78, 45),new List<int>(){9506}) },
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
