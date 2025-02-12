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
            // (level, exp, maxHp, maxMp, atk, spellPower, def)

            // 1 ~ 10층 (튜토리얼)
            { 8000, new Enemy("슬라임", 70, new Stat(3, 1, 80, 30, 8, 8, 4), null) },
            { 8001, new Enemy("거미", 70, new Stat(6, 1, 100, 40, 11, 11, 6), null) },
            { 8002, new Enemy("버섯", 70, new Stat(9, 1, 120, 50, 14, 14, 8), null) },

            { 8003, new Enemy("화난 슬라임", 70, new Stat(12, 1, 140, 60, 17, 17, 10), null) },
            { 8004, new Enemy("독거미", 70, new Stat(15, 1, 160, 70, 20, 20, 12), null) },
            { 8005, new Enemy("뿔버섯", 70, new Stat(18, 1, 180, 80, 23, 23, 14), null) },

            { 8006, new Enemy("포이즌 슬라임", 70, new Stat(21, 1, 200, 90, 26, 26, 16), null) },
            { 8007, new Enemy("거대 거미", 70, new Stat(24, 1, 220, 100, 29, 29, 18), null) },
            { 8008, new Enemy("독버섯", 70, new Stat(27, 1, 240, 110, 32, 32, 20), null) },

            { 8009, new Enemy("가디언 I", 70, new Stat(30, 1, 260, 120, 35, 35, 22), null) },

            // 11 ~ 20층 (야생)
            { 8010, new Enemy("박쥐", 70, new Stat(33, 1, 280, 130, 38, 38, 24), null) },
            { 8011, new Enemy("뱀", 70, new Stat(36, 1, 300, 140, 41, 41, 26), null) },
            { 8012, new Enemy("멧돼지", 70, new Stat(39, 1, 320, 150, 44, 44, 28), null) },

            { 8013, new Enemy("흡혈 박쥐", 70, new Stat(42, 1, 340, 160, 47, 47, 30), null) },
            { 8014, new Enemy("코브라", 70, new Stat(45, 1, 360, 170, 50, 50, 32), null) },
            { 8015, new Enemy("화난 멧돼지", 70, new Stat(48, 1, 380, 180, 53, 53, 34), null) },

            { 8016, new Enemy("코로나 박쥐", 70, new Stat(51, 1, 400, 190, 56, 56, 36), null) },
            { 8017, new Enemy("아나콘다", 70, new Stat(54, 1, 420, 200, 59, 59, 38), null) },
            { 8018, new Enemy("거대한 멧돼지", 70, new Stat(57, 1, 440, 210, 62, 62, 40), null) },

            { 8019, new Enemy("가디언 II", 70, new Stat(60, 1, 460, 220, 65, 65, 42), null) },

            // 21 ~ 30층 (언데드)
            { 8020, new Enemy("좀비", 1000, new Stat(63, 1, 480, 230, 68, 68, 44), null) },
            { 8021, new Enemy("해골 기사", 1000, new Stat(66, 1, 500, 240, 71, 71, 46), null) },
            { 8022, new Enemy("뱀파이어", 1000, new Stat(69, 1, 520, 250, 74, 74, 48), null) },

            { 8023, new Enemy("부패한 좀비", 1000, new Stat(72, 1, 540, 260, 77, 77, 50), null) },
            { 8024, new Enemy("격노한 해골기사", 1000, new Stat(75, 1, 560, 270, 80, 80, 52), null) },
            { 8025, new Enemy("굶주린 뱀파이어", 1000, new Stat(78, 1, 580, 280, 83, 83, 54), null) },

            { 8026, new Enemy("심연의 좀비", 1000, new Stat(81, 1, 600, 290, 86, 86, 56), null) },
            { 8027, new Enemy("저주의 해골기사", 1000, new Stat(84, 1, 620, 300, 89, 89, 58), null) },
            { 8028, new Enemy("황혼의 뱀파이어", 1000, new Stat(87, 1, 640, 310, 92, 92, 60), null) },

            { 8029, new Enemy("종말의 집행자", 1000, new Stat(90, 1, 660, 320, 95, 95, 62), null) },

            // 31 ~ 40층 (지옥)
            { 8030, new Enemy("리치", 1000, new Stat(93, 1, 680, 330, 98, 98, 64), null) },
            { 8031, new Enemy("데스나이트", 1000, new Stat(96, 1, 700, 340, 101, 101, 66), null) },
            { 8032, new Enemy("보닥", 1000, new Stat(99, 1, 720, 350, 104, 104, 68), null) },

            { 8033, new Enemy("황혼의 리치", 1000, new Stat(102, 1, 740, 360, 107, 107, 70), null) },
            { 8034, new Enemy("암흑 데스나이트", 1000, new Stat(105, 1, 760, 370, 110, 110, 72), null) },
            { 8035, new Enemy("불길한 보닥", 1000, new Stat(108, 1, 780, 380, 113, 113, 74), null) },

            { 8036, new Enemy("혼돈의 리치", 1000, new Stat(111, 1, 800, 390, 116, 116, 76), null) },
            { 8037, new Enemy("파멸 데스나이트", 1000, new Stat(114, 1, 820, 400, 119, 119, 78), null) },
            { 8038, new Enemy("재앙의 보닥", 1000, new Stat(117, 1, 840, 410, 122, 122, 80), null) },

            { 8039, new Enemy("타락 천사", 1000, new Stat(120, 1, 860, 420, 125, 125, 82), null) },

            // 41 ~ 50 (정령)
            { 8040, new Enemy("물의 정령", 70, new Stat(123, 1, 900, 440, 131, 131, 86), null)},
            { 8041, new Enemy("불의 정령", 70, new Stat(126, 1, 920, 450, 134, 134, 88), null)},
            { 8042, new Enemy("바람의 정령", 70, new Stat(129, 1, 940, 460, 137, 137, 90), null)},

            { 8043, new Enemy("대지의 정령", 70, new Stat(132, 1, 960, 470, 140, 140, 92), null)},
            { 8044, new Enemy("번개의 정령", 70, new Stat(135, 1, 980, 480, 143, 143, 94), null)},
            { 8045, new Enemy("얼음의 정령", 70, new Stat(138, 1, 1000, 490, 147, 147, 96), null)},

            { 8046, new Enemy("숲의 정령", 70, new Stat(141, 1, 1020, 500, 150, 150, 98), null)},
            { 8047, new Enemy("독의 정령", 70, new Stat(144, 1, 1040, 510, 153, 153, 100), null)},
            { 8048, new Enemy("빛의 정령", 70, new Stat(147, 1, 1060, 520, 156, 156, 102), null)},

            { 8089, new Enemy("어둠의 정령", 70, new Stat(150, 1, 1080, 530, 159, 159, 104), null)},

            // 51 ~ 60 (늑대인간)
            { 8050, new Enemy("펜리르 ", 70, new Stat(153, 1, 1100, 540, 162, 162, 106), null)},
            { 8051, new Enemy("루가루 ", 70, new Stat(156, 1, 1120, 550, 165, 165, 108), null)},
            { 8052, new Enemy("바르가스트 ", 70, new Stat(159, 1, 1140, 560, 168, 168, 110), null)},

            { 8053, new Enemy("울프가르 ", 70, new Stat(162, 1, 1160, 570, 171, 171, 112), null)},
            { 8054, new Enemy("라이커스 ", 70, new Stat(165, 1, 1180, 580, 174, 174, 114), null)},
            { 8055, new Enemy("가르울프 ", 70, new Stat(168, 1, 1200, 590, 177, 177, 116), null)},

            { 8056, new Enemy("스칼드락 ", 70, new Stat(171, 1, 1220, 600, 180, 180, 118), null)},
            { 8057, new Enemy("드라울프 ", 70, new Stat(174, 1, 1240, 610, 183, 183, 120), null)},
            { 8058, new Enemy("모른가르 ", 70, new Stat(177, 1, 1260, 620, 186, 186, 122), null)},

            { 8059, new Enemy("울프릭 ", 70, new Stat(180, 1, 1280, 630, 189, 189, 124), null)},

            // 61 ~ 70 (골렘)
            { 8060, new Enemy("바위골렘 ", 70, new Stat(183, 1, 1300, 640, 192, 192, 126), null)},
            { 8061, new Enemy("돌철골렘 ", 70, new Stat(186, 1, 1320, 650, 195, 195, 128), null)},
            { 8062, new Enemy("흙골렘", 70, new Stat(189, 1, 1340, 660, 198, 198, 130), null)},

            { 8063, new Enemy("모래골렘", 70, new Stat(192, 1, 1360, 670, 201, 201, 132), null)},
            { 8064, new Enemy("용암골렘", 70, new Stat(195, 1, 1380, 680, 204, 204, 134), null)},
            { 8065, new Enemy("철골렘", 70, new Stat(198, 1, 1400, 690, 207, 207, 136), null)},

            { 8066, new Enemy("검은바위골렘", 70, new Stat(201, 1, 1420, 700, 210, 210, 138), null)},
            { 8067, new Enemy("얼음골렘", 70, new Stat(204, 1, 1440, 710, 213, 213, 140), null)},
            { 8068, new Enemy("이끼바위골렘", 70, new Stat(207, 1, 1460, 720, 216, 216, 142), null)},

            { 8069, new Enemy("수정골렘 ", 70, new Stat(210, 1, 1480, 730, 219, 219, 144), null)},

            // 71 ~ 80 (거인)
            { 8070, new Enemy("수호의 거인", 70, new Stat(213, 1, 1500, 730, 222, 222, 146), null)},
            { 8071, new Enemy("대지의 거인", 70, new Stat(216, 1, 1520, 740, 225, 225, 148), null)},
            { 8072, new Enemy("불꽃의 거인", 70, new Stat(219, 1, 1540, 750, 228, 228, 150), null)},

            { 8073, new Enemy("심해의 거인", 70, new Stat(222, 1, 1560, 760, 231, 231, 152), null)},
            { 8074, new Enemy("천둥의 거인", 70, new Stat(225, 1, 1580, 770, 234, 234, 154), null)},
            { 8075, new Enemy("숲의 거인", 70, new Stat(228, 1, 1600, 780, 237, 237, 156), null)},

            { 8076, new Enemy("얼음의 거인", 70, new Stat(231, 1, 1620, 790, 240, 240, 158), null)},
            { 8077, new Enemy("황금의 거인", 70, new Stat(234, 1, 1640, 800, 243, 243, 160), null)},
            { 8078, new Enemy("죽음의 거인", 70, new Stat(237, 1, 1660, 810, 246, 246, 162), null)},

            { 8079, new Enemy("빛의 거인", 70, new Stat(240, 1, 1680, 820, 246, 246, 164), null)},

            // 81 ~ 90층 (용족)
            { 8080, new Enemy("드레이크", 2750, new Stat(240, 1, 1660, 820, 245, 245, 162), null)},
            { 8081, new Enemy("와이번", 3000, new Stat(243, 1, 1680, 820, 245, 245, 162), null)},
            { 8082, new Enemy("드래곤", 3250, new Stat(246, 1, 1700, 820, 245, 245, 162), null)},

            { 8083, new Enemy("푸른 드레이크", 2750, new Stat(245, 1, 1860, 918, 274, 274, 181), null)},
            { 8084, new Enemy("강렬한 와이번", 3000, new Stat(248, 1, 1881, 918, 274, 274, 181), null)},
            { 8085, new Enemy("위압적인 드래곤", 3250, new Stat(251, 1, 1904, 918, 274, 274, 181), null)},

            { 8086, new Enemy("거대한 드레이크", 2750, new Stat(250, 1, 2075, 1025, 306,306, 202), null)},
            { 8087, new Enemy("암흑의 와이번", 3000, new Stat(253, 1, 2100, 1025, 306,306, 202), null)},
            { 8088, new Enemy("진홍의 드래곤", 3250, new Stat(256, 1, 2125, 1025, 306, 306,202), null)},

            { 8089, new Enemy("스켈레톤 드래곤", 8250, new Stat(261, 3, 4150, 2050, 612, 612, 405), null)},

            // 91 ~ 100층 (고대)
            { 8090, new Enemy("켄타우로스", 3500, new Stat(270, 1, 1860, 920, 275, 275, 182), null)},
            { 8091, new Enemy("케르베로스", 3750, new Stat(273, 1, 1880, 930, 278, 278, 184), null)},
            { 8092, new Enemy("드래곤로드", 4000, new Stat(276, 1, 1900, 940, 281, 281, 186), null)},

            { 8093, new Enemy("붉은 켄타우로스", 3500, new Stat(275, 1, 2083, 1030, 308, 308, 203), null)},
            { 8094, new Enemy("붉은 케르베로스", 3750, new Stat(278, 1, 2105, 1041, 311, 311, 206), null)},
            { 8095, new Enemy("굳센 드래곤로드", 4000, new Stat(281, 1, 2128, 1052, 314, 314, 208), null)},

            { 8096, new Enemy("심연 켄타우로스", 3500, new Stat(280, 1, 2325, 1150, 343, 343, 227), null)},
            { 8097, new Enemy("지옥 케르베로스", 3750, new Stat(283, 1, 2350, 1162, 347, 347, 230), null)},
            { 8098, new Enemy("레드 드래곤로드", 4000, new Stat(286, 1, 2375, 1175, 351, 351, 232), null)},

            { 8099, new Enemy("망각의 군주", 12000, new Stat(291, 1, 4750, 2350, 702, 702, 465), null)}
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