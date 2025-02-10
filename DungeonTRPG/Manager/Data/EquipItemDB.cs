using DungeonTRPG.Items;
using DungeonTRPG.ItemsSystem;
using DungeonTRPG.Utility.Enums;
using Newtonsoft.Json;

namespace DungeonTRPG.Manager.Data
{
    internal class EquipItemDB
    {
        [JsonProperty]
        public Dictionary<int, EquipItem> Items { get; } = new Dictionary<int, EquipItem>()
        {
            // WEAPON
            { 2000, new EquipItem(
                "새벽의 검",
                "기초적인 무기지만 전사의 첫 걸음을 돕는 검. 약간의 공격력 보너스를 준다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(0, 0, 5, 0),   // HP, MP, Atk, Def
                EquipSlot.WEAPON)
            },
            { 2001, new EquipItem(
                "월광의 단도",
                "달빛의 힘을 담은 단도로, 더욱 강력한 공격력을 선사한다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(0, 0, 8, 0),
                EquipSlot.WEAPON)
            },
            { 2002, new EquipItem(
                "폭풍의 도끼",
                "폭풍처럼 강렬한 일격을 가할 수 있는 무기. 공격력에 중점을 두었다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(0, 0, 12, 0),
                EquipSlot.WEAPON)
            },
            { 2999, new EquipItem(
                "천상의 엑스칼리버",
                "전설 속 신들이 선택한 검으로, 엄청난 공격력 보너스를 지닌다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(0, 0, 30, 0),
                EquipSlot.WEAPON)
            },

            // HELMET
            { 3000, new EquipItem(
                "수호자의 투구",
                "견고한 재질로 만들어진 투구로, 착용 시 HP와 방어력이 상승한다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(10, 0, 0, 3),
                EquipSlot.HELMET)
            },
            { 3001, new EquipItem(
                "지혜의 왕관",
                "지혜의 상징인 이 관은 MP와 HP를 약간 보강해준다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(8, 5, 0, 2),
                EquipSlot.HELMET)
            },

            // CHESTPLATE
            { 4000, new EquipItem(
                "불굴의 갑옷",
                "전투에서의 생존력을 높여주는 갑옷. 높은 HP와 방어력 보너스를 제공한다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(20, 0, 0, 7),
                EquipSlot.CHESTPLATE)
            },
            { 4001, new EquipItem(
                "용의 비늘 판금갑옷",
                "드래곤의 비늘로 만들어져 뛰어난 방어력을 자랑하는 갑옷.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(15, 0, 0, 10),
                EquipSlot.CHESTPLATE)
            },

            // LEGGINGS
            { 5000, new EquipItem(
                "투명 다리 보호구",
                "불가사의한 수정과 그림자가 어우러진 소재로 제작되어, 착용자의 윤곽을 흐리게 만든다. 전투 중 HP와 방어력이 소폭 증가한다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(5, 0, 0, 4),
                EquipSlot.LEGGINGS)
            },
            { 5001, new EquipItem(
                "꽃무늬 바지",
                "화사한 꽃무늬가 돋보이는 바지로, 전투 중에도 기분 좋은 보너스를 제공한다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(5, 5, 0, 3),
                EquipSlot.LEGGINGS)
            },

            // BOOTS
            { 6000, new EquipItem(
                "바람의 장화",
                "가볍고 민첩한 움직임을 돕는 부츠로, 약간의 HP와 방어력을 보강한다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(3, 0, 0, 3),
                EquipSlot.BOOTS)
            },
            { 6001, new EquipItem(
                "대지의 발걸음",
                "단단한 지면 위를 걷는 듯한 안정감을 주는 부츠로, 방어력에 중점을 두었다.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(2, 0, 0, 5),
                EquipSlot.BOOTS)
            },

            // ACCESSORY
            { 7000, new EquipItem(
                "생명의 목걸이",
                "착용자에게 큰 HP 보너스를 제공하는 신비로운 목걸이.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(15, 0, 0, 0),
                EquipSlot.ACCESSORY)
            },
            { 7001, new EquipItem(
                "마력의 반지",
                "MP를 크게 증가시켜 마법 사용에 도움을 주는 반지.",
                new List<Job>{ Job.Warrior },
                new ExtraStat(0, 10, 0, 0),
                EquipSlot.ACCESSORY)
            },
        };

        public EquipItem GetByKey(int key)
        {
            if (Items.ContainsKey(key))
            {
                return Items[key];
            }
            return null;
        }
    }
}
