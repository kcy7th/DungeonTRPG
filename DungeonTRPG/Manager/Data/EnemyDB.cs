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
            //81층~90층 (8080~8089)
            //일반 (8080~8082)
            { 8080, new Enemy("드레이크", 2750, new Stat(240, 1, 1660, 820, 245, 245, 162), null)},
            { 8081, new Enemy("와이번", 3000, new Stat(243, 1, 1680, 820, 245, 245, 162), null)},
            { 8082, new Enemy("드래곤", 3250, new Stat(246, 1, 1700, 820, 245, 245, 162), null)},

            //강화 (8083~8085) (일반 몬스터의 1.12배, 레벨 +5)
            { 8083, new Enemy("푸른 드레이크", 2750, new Stat(245, 1, 1860, 918, 274, 274, 181), null)},
            { 8084, new Enemy("강렬한 와이번", 3000, new Stat(248, 1, 1881, 918, 274, 274, 181), null)},
            { 8085, new Enemy("위압적인 드래곤", 3250, new Stat(251, 1, 1904, 918, 274, 274, 181), null)},

            //최종 (8086~8088) (일반 몬스터의 1.25배, 레벨 +10)
            { 8086, new Enemy("거대한 드레이크", 2750, new Stat(250, 1, 2075, 1025, 306,306, 202), null)},
            { 8087, new Enemy("암흑의 와이번", 3000, new Stat(253, 1, 2100, 1025, 306,306, 202), null)},
            { 8088, new Enemy("진홍의 드래곤", 3250, new Stat(256, 1, 2125, 1025, 306, 306,202), null)},

            //보스 (8089) (일반 몬스터의 2.5배, 경험치는 3배, 레벨 +15)
            { 8089, new Enemy("스켈레톤 드래곤", 8250, new Stat(261, 3, 4150, 2050, 612, 612, 405), null)},
            //91층~100층 (8090~8099)


            //91층~10층 (8090~8099)
            //일반 (8090~8092)
            { 8090, new Enemy("켄타우로스", 3500, new Stat(270, 1, 1860, 920, 275, 275, 182), null)},
            { 8091, new Enemy("케르베로스", 3750, new Stat(273, 1, 1880, 930, 278, 278, 184), null)},
            { 8092, new Enemy("드래곤로드", 4000, new Stat(276, 1, 1900, 940, 281, 281, 186), null)},

            //강화 (8093~8095) (일반 몬스터의 1.12배, 레벨 +5)
            { 8093, new Enemy("붉은 켄타우로스", 3500, new Stat(275, 1, 2083, 1030, 308, 308, 203), null)},
            { 8094, new Enemy("붉은 케르베로스", 3750, new Stat(278, 1, 2105, 1041, 311, 311, 206), null)},
            { 8095, new Enemy("굳센 드래곤로드", 4000, new Stat(281, 1, 2128, 1052, 314, 314, 208), null)},

            //최종 (8096~8098) (일반 몬스터의 1.25배, 레벨 +10)
            { 8096, new Enemy("심연의 켄타우로스", 3500, new Stat(280, 1, 2325, 1150, 343, 343, 227), null)},
            { 8097, new Enemy("지옥의 케르베로스", 3750, new Stat(283, 1, 2350, 1162, 347, 347, 230), null)},
            { 8098, new Enemy("레드 드래곤로드", 4000, new Stat(286, 1, 2375, 1175, 351, 351, 232), null)},

            //보스 (8099) (일반 몬스터의 2.5배, 경험치는 3배, 레벨 +15)
            { 8099, new Enemy("망각의 군주", 12000, new Stat(291, 1, 4750, 2350, 702, 702, 465), null)},
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
