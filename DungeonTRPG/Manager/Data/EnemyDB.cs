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
            // (level, exp, maxHp, maxMp, atk, spellPower, def)

            // 1 ~ 10층 (튜토리얼)
            { 8000, new Enemy("슬라임", 50, new Stat(3, 10, 80, 30, 8, 8, 4), new List<int>(){}) },
            { 8001, new Enemy("거미", 60, new Stat(6, 11, 100, 40, 11, 11, 6), new List<int>(){}) },
            { 8002, new Enemy("버섯", 70, new Stat(9, 12, 120, 50, 14, 14, 8), new List<int>(){}) },

            { 8003, new Enemy("화난 슬라임", 80, new Stat(12, 13, 140, 60, 17, 17, 10), new List<int>(){}) },
            { 8004, new Enemy("독거미", 90, new Stat(15, 14, 160, 70, 20, 20, 12), new List<int>(){}) },
            { 8005, new Enemy("뿔버섯", 100, new Stat(18, 15, 180, 80, 23, 23, 14), new List<int>(){}) },

            { 8006, new Enemy("포이즌 슬라임", 110, new Stat(21, 16, 200, 90, 26, 26, 16), new List<int>(){}) },
            { 8007, new Enemy("거대 거미", 120, new Stat(24, 17, 220, 100, 29, 29, 18), new List<int>(){}) },
            { 8008, new Enemy("독버섯", 130, new Stat(27, 18, 240, 110, 32, 32, 20), new List<int>(){}) },

            { 8009, new Enemy("가디언 I", 140, new Stat(30, 19, 260, 120, 35, 35, 22), new List<int>(){}) },

            // 11 ~ 20층 (야생)
            { 8010, new Enemy("박쥐", 160, new Stat(33, 20, 280, 130, 38, 38, 24), new List<int>(){}) },
            { 8011, new Enemy("뱀", 180, new Stat(36, 21, 300, 140, 41, 41, 26), new List<int>(){}) },
            { 8012, new Enemy("멧돼지", 200, new Stat(39, 22, 320, 150, 44, 44, 28), new List<int>(){}) },

            { 8013, new Enemy("흡혈 박쥐", 220, new Stat(42, 23, 340, 160, 47, 47, 30), new List<int>(){}) },
            { 8014, new Enemy("코브라", 240, new Stat(45, 24, 360, 170, 50, 50, 32), new List<int>(){}) },
            { 8015, new Enemy("화난 멧돼지", 260, new Stat(48, 25, 380, 180, 53, 53, 34), new List<int>(){}) },

            { 8016, new Enemy("코로나 박쥐", 280, new Stat(51, 26, 400, 190, 56, 56, 36), new List<int>(){}) },
            { 8017, new Enemy("아나콘다", 300, new Stat(54, 27, 420, 200, 59, 59, 38), new List<int>(){}) },
            { 8018, new Enemy("거대한 멧돼지", 320, new Stat(57, 28, 440, 210, 62, 62, 40), new List<int>(){}) },

            { 8019, new Enemy("가디언 II", 340, new Stat(60, 29, 460, 220, 65, 65, 42), new List<int>(){}) },

            // 21 ~ 30층 (언데드)
            { 8020, new Enemy("좀비", 380, new Stat(63, 30, 480, 230, 68, 68, 44), new List<int>(){}) },
            { 8021, new Enemy("해골 기사", 420, new Stat(66, 31, 500, 240, 71, 71, 46), new List<int>(){}) },
            { 8022, new Enemy("뱀파이어", 460, new Stat(69, 32, 520, 250, 74, 74, 48), new List<int>(){}) },

            { 8023, new Enemy("부패한 좀비", 500, new Stat(72, 33, 540, 260, 77, 77, 50), new List<int>(){}) },
            { 8024, new Enemy("격노한 해골기사", 540, new Stat(75, 34, 560, 270, 80, 80, 52), new List<int>(){}) },
            { 8025, new Enemy("굶주린 뱀파이어", 580, new Stat(78, 35, 580, 280, 83, 83, 54), new List<int>(){}) },

            { 8026, new Enemy("심연의 좀비", 620, new Stat(81, 36, 600, 290, 86, 86, 56), new List<int>(){}) },
            { 8027, new Enemy("저주의 해골기사", 660, new Stat(84, 37, 620, 300, 89, 89, 58), new List<int>(){}) },
            { 8028, new Enemy("황혼의 뱀파이어", 700, new Stat(87, 38, 640, 310, 92, 92, 60), new List<int>(){}) },

            { 8029, new Enemy("종말의 집행자", 740, new Stat(90, 39, 660, 320, 95, 95, 62), new List<int>(){}) },

            // 31 ~ 40층 (지옥)
            { 8030, new Enemy("리치", 820, new Stat(93, 40, 680, 330, 98, 98, 64), new List<int>(){}) },
            { 8031, new Enemy("데스나이트", 900, new Stat(96, 41, 700, 340, 101, 101, 66), new List<int>(){}) },
            { 8032, new Enemy("보닥", 980, new Stat(99, 42, 720, 350, 104, 104, 68), new List<int>(){}) },

            { 8033, new Enemy("황혼의 리치", 1060, new Stat(102, 43, 740, 360, 107, 107, 70), new List<int>(){}) },
            { 8034, new Enemy("암흑 데스나이트", 1140, new Stat(105, 44, 760, 370, 110, 110, 72), new List<int>(){}) },
            { 8035, new Enemy("불길한 보닥", 1220, new Stat(108, 45, 780, 380, 113, 113, 74), new List<int>(){}) },

            { 8036, new Enemy("혼돈의 리치", 1300, new Stat(111, 46, 800, 390, 116, 116, 76), new List<int>(){}) },
            { 8037, new Enemy("파멸 데스나이트", 1380, new Stat(114, 47, 820, 400, 119, 119, 78), new List<int>(){}) },
            { 8038, new Enemy("재앙의 보닥", 1460, new Stat(117, 48, 840, 410, 122, 122, 80), new List<int>(){}) },

            { 8039, new Enemy("타락 천사", 1440, new Stat(120, 49, 860, 420, 125, 125, 82), new List<int>(){}) },

            // 41 ~ 50 (정령)
            { 8040, new Enemy("물의 정령", 1600, new Stat(123, 50, 900, 440, 131, 131, 86), new List<int>(){})},
            { 8041, new Enemy("불의 정령", 1760, new Stat(126, 51, 920, 450, 134, 134, 88), new List<int>(){})},
            { 8042, new Enemy("바람의 정령", 1920, new Stat(129, 52, 940, 460, 137, 137, 90), new List<int>(){})},

            { 8043, new Enemy("대지의 정령", 2080, new Stat(132, 53, 960, 470, 140, 140, 92), new List<int>(){})},
            { 8044, new Enemy("번개의 정령", 2240, new Stat(135, 54, 980, 480, 143, 143, 94), new List<int>(){})},
            { 8045, new Enemy("얼음의 정령", 2400, new Stat(138, 55, 1000, 490, 147, 147, 96), new List<int>(){})},

            { 8046, new Enemy("숲의 정령", 2560, new Stat(141, 56, 1020, 500, 150, 150, 98), new List<int>(){})},
            { 8047, new Enemy("독의 정령", 2720, new Stat(144, 57, 1040, 510, 153, 153, 100), new List<int>(){})},
            { 8048, new Enemy("빛의 정령", 2880, new Stat(147, 58, 1060, 520, 156, 156, 102), new List<int>(){})},

            { 8049, new Enemy("어둠의 정령", 3040, new Stat(150, 59, 1080, 530, 159, 159, 104), new List<int>(){})},

            // 51 ~ 60 (늑대인간)
            { 8050, new Enemy("펜리르 ", 3360, new Stat(153, 60, 1100, 540, 162, 162, 106), new List<int>(){})},
            { 8051, new Enemy("루가루 ", 3680, new Stat(156, 61, 1120, 550, 165, 165, 108), new List<int>(){})},
            { 8052, new Enemy("바르가스트 ", 4000, new Stat(159, 62, 1140, 560, 168, 168, 110), new List<int>(){})},

            { 8053, new Enemy("울프가르 ", 4320, new Stat(162, 63, 1160, 570, 171, 171, 112), new List<int>(){})},
            { 8054, new Enemy("라이커스 ", 4640, new Stat(165, 64, 1180, 580, 174, 174, 114), new List<int>(){})},
            { 8055, new Enemy("가르울프 ", 4960, new Stat(168, 65, 1200, 590, 177, 177, 116), new List<int>(){})},

            { 8056, new Enemy("스칼드락 ", 5280, new Stat(171, 66, 1220, 600, 180, 180, 118), new List<int>(){})},
            { 8057, new Enemy("드라울프 ", 5600, new Stat(174, 67, 1240, 610, 183, 183, 120), new List<int>(){})},
            { 8058, new Enemy("모른가르 ", 5920, new Stat(177, 68, 1260, 620, 186, 186, 122), new List<int>(){})},

            { 8059, new Enemy("울프릭 ", 6240, new Stat(180, 69, 1280, 630, 189, 189, 124), new List<int>(){})},

            // 61 ~ 70 (골렘)
            { 8060, new Enemy("바위골렘 ", 6880, new Stat(183, 70, 1300, 640, 192, 192, 126), new List<int>(){})},
            { 8061, new Enemy("돌철골렘 ", 7520, new Stat(186, 71, 1320, 650, 195, 195, 128), new List<int>(){})},
            { 8062, new Enemy("흙골렘", 8160, new Stat(189, 72, 1340, 660, 198, 198, 130), new List<int>(){})},

            { 8063, new Enemy("모래골렘", 8800, new Stat(192, 73, 1360, 670, 201, 201, 132), new List<int>(){})},
            { 8064, new Enemy("용암골렘", 9440, new Stat(195, 74, 1380, 680, 204, 204, 134), new List<int>(){})},
            { 8065, new Enemy("철골렘", 10080, new Stat(198, 75, 1400, 690, 207, 207, 136), new List<int>(){})},

            { 8066, new Enemy("검은바위골렘", 10720, new Stat(201, 76, 1420, 700, 210, 210, 138), new List<int>(){})},
            { 8067, new Enemy("얼음골렘", 11360, new Stat(204, 77, 1440, 710, 213, 213, 140), new List<int>(){})},
            { 8068, new Enemy("이끼바위골렘", 12000, new Stat(207, 78, 1460, 720, 216, 216, 142), new List<int>(){})},

            { 8069, new Enemy("수정골렘 ", 12640, new Stat(210, 79, 1480, 730, 219, 219, 144), new List<int>(){})},

            // 71 ~ 80 (거인)
            { 8070, new Enemy("수호의 거인", 13920, new Stat(213, 80, 1500, 730, 222, 222, 146), new List<int>(){})},
            { 8071, new Enemy("대지의 거인", 15200, new Stat(216, 81, 1520, 740, 225, 225, 148), new List<int>(){})},
            { 8072, new Enemy("불꽃의 거인", 16480, new Stat(219, 82, 1540, 750, 228, 228, 150), new List<int>(){})},

            { 8073, new Enemy("심해의 거인", 17760, new Stat(222, 83, 1560, 760, 231, 231, 152), new List<int>(){})},
            { 8074, new Enemy("천둥의 거인", 19040, new Stat(225, 84, 1580, 770, 234, 234, 154), new List<int>(){})},
            { 8075, new Enemy("숲의 거인", 20320, new Stat(228, 85, 1600, 780, 237, 237, 156), new List<int>(){})},

            { 8076, new Enemy("얼음의 거인", 21600, new Stat(231, 86, 1620, 790, 240, 240, 158), new List<int>(){})},
            { 8077, new Enemy("황금의 거인", 22880, new Stat(234, 87, 1640, 800, 243, 243, 160), new List<int>(){})},
            { 8078, new Enemy("죽음의 거인", 24160, new Stat(237, 88, 1660, 810, 246, 246, 162), new List<int>(){})},

            { 8079, new Enemy("빛의 거인", 25400, new Stat(240, 89, 1680, 820, 246, 246, 164), new List<int>(){})},

            // 81 ~ 90층 (용족)
            { 8080, new Enemy("드레이크", 28000, new Stat(240, 90, 1660, 820, 245, 245, 162), new List<int>(){})},
            { 8081, new Enemy("와이번", 30560, new Stat(243, 91, 1680, 820, 245, 245, 162), new List<int>(){})},
            { 8082, new Enemy("드래곤", 33120, new Stat(246, 92, 1700, 820, 245, 245, 162), new List<int>(){})},

            { 8083, new Enemy("푸른 드레이크", 35680, new Stat(245, 93, 1860, 918, 274, 274, 181), new List<int>(){})},
            { 8084, new Enemy("강렬한 와이번", 38240, new Stat(248, 94, 1881, 918, 274, 274, 181), new List<int>(){})},
            { 8085, new Enemy("위압적인 드래곤", 40800, new Stat(251, 95, 1904, 918, 274, 274, 181), new List<int>(){})},

            { 8086, new Enemy("거대한 드레이크", 43360, new Stat(250, 96, 2075, 1025, 306,306, 202), new List<int>(){})},
            { 8087, new Enemy("암흑의 와이번", 45920, new Stat(253, 97, 2100, 1025, 306,306, 202), new List<int>(){})},
            { 8088, new Enemy("진홍의 드래곤", 48480, new Stat(256, 98, 2125, 1025, 306, 306,202), new List<int>(){})},

            { 8089, new Enemy("스켈레톤 드래곤", 51040, new Stat(261, 99, 4150, 2050, 612, 612, 405), new List<int>(){})},

            // 91 ~ 100층 (고대)
            { 8090, new Enemy("켄타우로스", 56160, new Stat(270, 100, 1860, 920, 275, 275, 182), new List<int>(){})},
            { 8091, new Enemy("케르베로스", 61280, new Stat(273, 101, 1880, 930, 278, 278, 184), new List<int>(){})},
            { 8092, new Enemy("드래곤로드", 66400, new Stat(276, 102, 1900, 940, 281, 281, 186), new List<int>(){})},

            { 8093, new Enemy("붉은 켄타우로스", 71520, new Stat(275, 103, 2083, 1030, 308, 308, 203), new List<int>(){})},
            { 8094, new Enemy("붉은 케르베로스", 76640, new Stat(278, 104, 2105, 1041, 311, 311, 206), new List<int>(){})},
            { 8095, new Enemy("굳센 드래곤로드", 81760, new Stat(281, 105, 2128, 1052, 314, 314, 208), new List<int>(){})},

            { 8096, new Enemy("심연 켄타우로스", 86880, new Stat(280, 106, 2325, 1150, 343, 343, 227), new List<int>(){})},
            { 8097, new Enemy("지옥 케르베로스", 92000, new Stat(283, 107, 2350, 1162, 347, 347, 230), new List<int>(){})},
            { 8098, new Enemy("레드 드래곤로드", 97120, new Stat(286, 108, 2375, 1175, 351, 351, 232), new List<int>(){})},

            { 8099, new Enemy("망각의 군주", 102240, new Stat(291, 109, 4750, 2350, 702, 702, 465), new List<int>(){})}
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