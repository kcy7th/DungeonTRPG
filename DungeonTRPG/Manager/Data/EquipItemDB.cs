using DungeonTRPG.ItemsSystem;
using DungeonTRPG.Items;
using DungeonTRPG.Utility.Enums;
using Newtonsoft.Json;

namespace DungeonTRPG.Manager.Data
{
    internal class EquipItemDB
    {
        [JsonProperty]
        private Dictionary<int, EquipItem> equipItems = new Dictionary<int, EquipItem>()
        {
            // 전사 무기
            { 2000, new EquipItem("철 검", "그럭저럭 쓸만해 보인다.", 1500, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 5, 0, 0), EquipSlot.WEAPON) },
            { 2001, new EquipItem("강철 검", "꽤나 단단해 보인다.", 3000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 9, 0, 0), EquipSlot.WEAPON) },
            { 2002, new EquipItem("흑도", "이름만큼 무겁다.", 6000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 14, 0, 0), EquipSlot.WEAPON) },
            { 2003, new EquipItem("지옥불 대검", "굉장히 뜨거워 보인다.", 12000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 18, 0, 0), EquipSlot.WEAPON) },
            { 2004, new EquipItem("엘리멘탈 소드", "정순한 기운이 담겨져 있다.", 24000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 23, 0, 0), EquipSlot.WEAPON) },
            { 2005, new EquipItem("은월도", "달의 기운이 담겨 있다.", 48000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 27, 0, 0), EquipSlot.WEAPON) },
            { 2006, new EquipItem("오리하르콘 대검", "절대 깨지지 않는 대검.", 96000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 32, 0, 0), EquipSlot.WEAPON) },
            { 2007, new EquipItem("거인의 거검", "이름만큼 거대한 검. 파괴력 만큼은 일품이다.", 192000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 38, 0, 0), EquipSlot.WEAPON) },
            { 2008, new EquipItem("용살검", "용의 피로 쌓아 올려진 검.", 384000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 41, 0, 0), EquipSlot.WEAPON) },
            { 2009, new EquipItem("돌 검", "고대에 사용한 걸로 추정되는 검. 오랜시간 미지의 기운이 담겨 강력하다.", 768000, new List<Job>{ Job.Warrior }, new ExtraStat(0, 0, 45, 0, 0), EquipSlot.WEAPON) },

            // 마법사 무기
            { 2100, new EquipItem("나무 지팡이", "가장 기초적인 지팡이. 마법사의 마력을 증가시킨다.", 1500, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 8, 0), EquipSlot.WEAPON) },
            { 2101, new EquipItem("호박 지팡이", "호박으로 포인트를 준 지팡이.", 3000, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 16, 0), EquipSlot.WEAPON) },
            { 2102, new EquipItem("네크로멘서의 마법서", "이름모를 네크로멘서가 집필한 책", 6000, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 23, 0), EquipSlot.WEAPON) },
            { 2103, new EquipItem("청염의 완드", "지옥불에 오랜시간 달궈졌다.", 12000, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 31, 0), EquipSlot.WEAPON) },
            { 2104, new EquipItem("양의 수정 지팡이", "양기가 가득한 곳에서 자라난 수정으로 만든 지팡이.", 24000, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 38, 0), EquipSlot.WEAPON) },
            { 2105, new EquipItem("광혈 수정", "달의 빛, 피가 모여 만들어진 수정.", 48000, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 46, 0), EquipSlot.WEAPON) },
            { 2106, new EquipItem("마법공학 완드", "마법과 공학의 정수가 담겨있다.", 96000, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 53, 0), EquipSlot.WEAPON) },
            { 2107, new EquipItem("거혈의 정수", "거인의 피로 쌓아올린 정수.", 192000, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 61, 0), EquipSlot.WEAPON) },
            { 2108, new EquipItem("용의 수정", "용들의 힘이 담겨 있다.", 384000, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 68, 0), EquipSlot.WEAPON) },
            { 2109, new EquipItem("■■■의 결정체", "정체 불명의 존재가 남기고간 물건.", 768000, new List<Job>{ Job.Mage }, new ExtraStat(0, 0, 0, 76, 0), EquipSlot.WEAPON) },

            // 궁수 무기
            { 2200, new EquipItem("연습용 활", "초보용 활. 연습하기 좋다.", 1500, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 2, 2, 0), EquipSlot.WEAPON) },
            { 2201, new EquipItem("나무 활", "질 좋은 나무를 사용한 듯 하다.", 3000, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 6, 3, 0), EquipSlot.WEAPON) },
            { 2202, new EquipItem("한기 서린 활", "한기가 서려있어 오래 사용하기 어렵다.", 6000, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 9, 5, 0), EquipSlot.WEAPON) },
            { 2203, new EquipItem("흑현 단도", "검붉은 같은 칼날이 특징이다.", 12000, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 12, 6, 0), EquipSlot.WEAPON) },
            { 2204, new EquipItem("바람의 석궁", "이름은 하찮지만, 능력만큼은 무시하기 어렵다.", 24000, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 15, 8, 0), EquipSlot.WEAPON) },
            { 2205, new EquipItem("신속의 활", "늑대인간의 능력이 담겨 있는 활", 48000, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 18, 9, 0), EquipSlot.WEAPON) },
            { 2206, new EquipItem("마법공학 석궁", "기술력으로 만들어진 석궁. 총과도 비견된다.", 96000, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 21, 11, 0), EquipSlot.WEAPON) },
            { 2207, new EquipItem("거인의 석궁", "거인의 인대로 만든 석궁. 장력이 상당하다.", 192000, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 24, 12, 0), EquipSlot.WEAPON) },
            { 2208, new EquipItem("용혈의 활", "공격 속도를 증가시키는 장갑", 384000, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 27, 14, 0), EquipSlot.WEAPON) },
            { 2209, new EquipItem("아르테미스의 활", "고대유적에서 발견한 활. 신의 힘이 담겨 있는 듯 한다.", 768000, new List<Job>{ Job.Archer }, new ExtraStat(0, 0, 30, 15, 0), EquipSlot.WEAPON) },

            // 투구
            { 3000, new EquipItem("수습 강철 투구", "전사 입문자가 사용하는 기본 철제 투구", 2000, new List<Job>{ Job.Warrior }, new ExtraStat(18, 0, 0, 0, 3), EquipSlot.HELMET) },
            { 3001, new EquipItem("야생의 전투 투구", "야생에서 살아남은 전사들이 애용하는 헬멧", 4000, new List<Job>{ Job.Warrior }, new ExtraStat(36, 0, 0, 0, 6), EquipSlot.HELMET) },
            { 3002, new EquipItem("지옥불의 강철 투구", "지옥의 불꽃 속에서도 견딜 수 있도록 강화된 투구", 8000, new List<Job>{ Job.Warrior }, new ExtraStat(54, 0, 0, 0, 9), EquipSlot.HELMET) },
            { 3003, new EquipItem("정령의 수호 투구", "정령의 마법이 깃든 보호용 투구", 12000, new List<Job>{ Job.Warrior }, new ExtraStat(73, 0, 0, 0, 12), EquipSlot.HELMET) },
            { 3004, new EquipItem("늑대의 투구", "늑대인간 전사들이 착용하던 투구", 24000, new List<Job>{ Job.Warrior }, new ExtraStat(91, 0, 0, 0, 15), EquipSlot.HELMET) },
            { 3005, new EquipItem("골렘의 방벽 투구", "골렘의 단단한 바위로 제작된 방어력 높은 투구", 48000, new List<Job>{ Job.Warrior }, new ExtraStat(109, 0, 0, 0, 18), EquipSlot.HELMET) },
            { 3006, new EquipItem("거인의 전투 투구", "거인족 전사들이 사용하던 강력한 투구", 96000, new List<Job>{ Job.Warrior }, new ExtraStat(127, 0, 0, 0, 21), EquipSlot.HELMET) },
            { 3007, new EquipItem("용족의 용맹 투구", "용족의 힘이 깃든 전설적인 투구", 192000, new List<Job>{ Job.Warrior }, new ExtraStat(145, 0, 0, 0, 24), EquipSlot.HELMET) },
            { 3008, new EquipItem("고대 전사의 헬름", "고대 전사들이 착용했던 전설적인 헬멧", 384000, new List<Job>{ Job.Warrior }, new ExtraStat(164, 0, 0, 0, 27), EquipSlot.HELMET) },
            { 3009, new EquipItem("신화의 전설 투구", "전설 속 신화급 전사만이 착용할 수 있는 투구", 968000, new List<Job>{ Job.Warrior }, new ExtraStat(182, 0, 0, 0, 30), EquipSlot.HELMET) },

            { 3100, new EquipItem("초보 마법사의 모자", "초보 마법사가 착용하는 기본적인 마법사 모자", 1000, new List<Job>{ Job.Mage }, new ExtraStat(11, 0, 0, 0, 8), EquipSlot.HELMET) },
            { 3101, new EquipItem("야생의 마법사 모자", "야생에서 수련을 거듭한 마법사들이 착용하는 모자", 2000, new List<Job>{ Job.Mage }, new ExtraStat(20, 0, 0, 0, 16), EquipSlot.HELMET) },
            { 3102, new EquipItem("지옥불의 마법사 모자", "지옥불에서 살아남은 마법사들이 착용하는 악마적인 모자", 4000, new List<Job>{ Job.Mage }, new ExtraStat(29, 0, 0, 0, 23), EquipSlot.HELMET) },
            { 3103, new EquipItem("정령의 마법사 모자", "정령의 힘이 깃든 마법사 모자", 8000, new List<Job>{ Job.Mage }, new ExtraStat(38, 0, 0, 0, 31), EquipSlot.HELMET) },
            { 3104, new EquipItem("늑대인간의 마법사 모자", "늑대인간 마법사들이 착용하는 강력한 마법사 모자", 16000, new List<Job>{ Job.Mage }, new ExtraStat(47, 0, 0, 0, 38), EquipSlot.HELMET) },
            { 3105, new EquipItem("골렘의 마법사 모자", "골렘 마법사들이 착용하는 튼튼한 마법사 모자", 32000, new List<Job>{ Job.Mage }, new ExtraStat(56, 0, 0, 0, 46), EquipSlot.HELMET) },
            { 3106, new EquipItem("거인의 마법사 모자", "힘이 넘치는 마법사 모자", 64000, new List<Job>{ Job.Mage }, new ExtraStat(65, 0, 0, 0, 53), EquipSlot.HELMET) },
            { 3107, new EquipItem("용족의 마법사 모자", "용족 마법사들이 착용하는 신비롭고 강력한 마법사 모자", 128000, new List<Job>{ Job.Mage }, new ExtraStat(74, 0, 0, 0, 53), EquipSlot.HELMET) },
            { 3108, new EquipItem("고대 마법사의 모자", "고대 마법사들의 지혜가 담긴 전설적인 마법사 모자", 256000, new List<Job>{ Job.Mage }, new ExtraStat(83, 0, 0, 0, 68), EquipSlot.HELMET) },
            { 3109, new EquipItem("신화의 마법사 모자", "신화 속 마법사들이 착용한 최고의 마법사 모자", 512000, new List<Job>{ Job.Mage }, new ExtraStat(92, 0, 0, 0, 76), EquipSlot.HELMET) },

            { 3200, new EquipItem("초보 사냥꾼의 모자", "처음 활을 쥔 사냥꾼을 위한 가벼운 모자", 1000, new List<Job>{ Job.Archer }, new ExtraStat(14, 0, 0, 0, 3), EquipSlot.HELMET) },
            { 3201, new EquipItem("야생의 두건", "숲과 들판에서 살아남기 위한 가죽 두건", 2000, new List<Job>{ Job.Archer }, new ExtraStat(27, 0, 0, 0, 6), EquipSlot.HELMET) },
            { 3202, new EquipItem("지옥불의 투구", "지옥의 불길을 머금은 붉은빛 투구", 4000, new List<Job>{ Job.Archer }, new ExtraStat(41, 0, 0, 0, 9), EquipSlot.HELMET) },
            { 3203, new EquipItem("정령의 가면", "바람의 정령이 깃든 신비로운 가면", 8000, new List<Job>{ Job.Archer }, new ExtraStat(55, 0, 0, 0, 12), EquipSlot.HELMET) },
            { 3204, new EquipItem("늑대의 투구", "늑대의 감각을 부여하는 야성적인 투구", 16000, new List<Job>{ Job.Archer }, new ExtraStat(68, 0, 0, 0, 15), EquipSlot.HELMET) },
            { 3205, new EquipItem("암석 헬름", "단단한 바위로 만들어진 궁수용 보호구", 32000, new List<Job>{ Job.Archer }, new ExtraStat(82, 0, 0, 0, 18), EquipSlot.HELMET) },
            { 3206, new EquipItem("거인의 전투 투구", "거인족 전사들이 사용하던 견고한 투구", 64000, new List<Job>{ Job.Archer }, new ExtraStat(96, 0, 0, 0, 21), EquipSlot.HELMET) },
            { 3207, new EquipItem("용혈의 투구", "용족의 피가 스며든 강력한 투구", 128000, new List<Job>{ Job.Archer }, new ExtraStat(110, 0, 0, 0, 24), EquipSlot.HELMET) },
            { 3208, new EquipItem("태고의 사냥꾼 투구", "고대 문명의 사냥꾼들이 사용한 전설의 투구", 256000, new List<Job>{ Job.Archer }, new ExtraStat(123, 0, 0, 0, 27), EquipSlot.HELMET) },
            { 3209, new EquipItem("신궁의 유산", "잊혀진 시대의 신궁들이 남긴 궁극의 투구", 512000, new List<Job>{ Job.Archer }, new ExtraStat(137, 0, 0, 0, 30), EquipSlot.HELMET) },
            
            // 갑옷
            { 4000, new EquipItem("수습 갑옷", "기본적인 전사 갑옷", 2000, new List<Job>{ Job.Warrior }, new ExtraStat(49, 0, 0, 0, 9), EquipSlot.CHESTPLATE) },
            { 4001, new EquipItem("야생의 전투 갑옷", "야생에서 살아남은 전사들이 착용하는 갑옷", 4000, new List<Job>{ Job.Warrior }, new ExtraStat(98, 0, 0, 0, 18), EquipSlot.CHESTPLATE) },
            { 4002, new EquipItem("지옥불의 수호 갑옷", "지옥의 불꽃 속에서도 버틸 수 있도록 강화된 갑옷", 8000, new List<Job>{ Job.Warrior }, new ExtraStat(147, 0, 0, 0, 27), EquipSlot.CHESTPLATE) },
            { 4003, new EquipItem("정령의 보호 갑옷", "정령의 마법이 깃든 강력한 갑옷", 16000, new List<Job>{ Job.Warrior }, new ExtraStat(196, 0, 0, 0, 36), EquipSlot.CHESTPLATE) },
            { 4004, new EquipItem("늑대의 전투 갑옷", "늑대인간 전사들이 착용하는 민첩한 갑옷", 32000, new List<Job>{ Job.Warrior }, new ExtraStat(245, 0, 0, 0, 45), EquipSlot.CHESTPLATE) },
            { 4005, new EquipItem("골렘의 방어 갑옷", "골렘의 단단한 암석으로 만들어진 갑옷", 64000, new List<Job>{ Job.Warrior }, new ExtraStat(294, 0, 0, 0, 54), EquipSlot.CHESTPLATE) },
            { 4006, new EquipItem("거인의 전투 갑옷", "거인족의 전사들이 착용하는 전투 갑옷", 128000, new List<Job>{ Job.Warrior }, new ExtraStat(343, 0, 0, 0, 63), EquipSlot.CHESTPLATE) },
            { 4007, new EquipItem("용족의 전설 갑옷", "용족의 강력한 비늘로 만들어진 갑옷", 256000, new List<Job>{ Job.Warrior }, new ExtraStat(392, 0, 0, 0, 72), EquipSlot.CHESTPLATE) },
            { 4008, new EquipItem("고대 전사들의 갑옷", "고대 전사들이 착용했던 전설적인 갑옷", 512000, new List<Job>{ Job.Warrior }, new ExtraStat(441, 0, 0, 0, 81), EquipSlot.CHESTPLATE) },
            { 4009, new EquipItem("신화의 전투 갑옷", "신화 속 전사만이 입을 수 있는 궁극의 갑옷", 1024000, new List<Job>{ Job.Warrior }, new ExtraStat(490, 0, 0, 0, 90), EquipSlot.CHESTPLATE) },

            { 4100, new EquipItem("마법사의 초급 로브", "마법사의 기본 로브. 마법을 배우는 자에게 필요한 기본 장비", 1200, new List<Job>{ Job.Mage }, new ExtraStat(28, 0, 0, 0, 24), EquipSlot.CHESTPLATE) },
            { 4101, new EquipItem("강화된 마법의 로브", "강화된 마법의 로브. 마법을 다루는 능력을 향상시켜주는 의복", 2400, new List<Job>{ Job.Mage }, new ExtraStat(52, 0, 0, 0, 47), EquipSlot.CHESTPLATE) },
            { 4102, new EquipItem("은빛 마법사의 옷", "마법의 흐름을 더욱 원활하게 만들어준다.", 4800, new List<Job>{ Job.Mage }, new ExtraStat(76, 0, 0, 0, 69), EquipSlot.CHESTPLATE) },
            { 4103, new EquipItem("황금빛 마법 로브", "황금빛으로 빛나는 로브. 강력한 마법사의 상징", 9600, new List<Job>{ Job.Mage }, new ExtraStat(100, 0, 0, 0, 92), EquipSlot.CHESTPLATE) },
            { 4104, new EquipItem("용의 불꽃 로브", "용의 불꽃을 모티브로 한 마법 로브. 강력한 마법 공격력 강화", 19200, new List<Job>{ Job.Mage }, new ExtraStat(124, 0, 0, 0, 114), EquipSlot.CHESTPLATE) },
            { 4105, new EquipItem("백금 마법 로브", "백금으로 제작된 마법 로브. 최고의 마법사의 특권", 38400, new List<Job>{ Job.Mage }, new ExtraStat(148, 0, 0, 0, 137), EquipSlot.CHESTPLATE) },
            { 4106, new EquipItem("천상의 마법의 로브", "천상의 힘이 깃든 마법 로브. 강력한 마법 방어력을 자랑", 76800, new List<Job>{ Job.Mage }, new ExtraStat(172, 0, 0, 0, 159), EquipSlot.CHESTPLATE) },
            { 4107, new EquipItem("심연의 마법 로브", "마법 공격력과 방어력이 강화된다.", 153600, new List<Job>{ Job.Mage }, new ExtraStat(196, 0, 0, 0, 182), EquipSlot.CHESTPLATE) },
            { 4108, new EquipItem("불사의 마법 로브", "마법을 더욱 강력하게 펼칠 수 있는 힘을 준다.", 307200, new List<Job>{ Job.Mage }, new ExtraStat(220, 0, 0, 0, 204), EquipSlot.CHESTPLATE) },
            { 4109, new EquipItem("신의 마법 로브", "신의 축복을 받은 로브. 모든 마법의 힘을 극대화시킨다.", 614400, new List<Job>{ Job.Mage }, new ExtraStat(244, 0, 0, 0, 227), EquipSlot.CHESTPLATE) },

            { 4200, new EquipItem("수습 가죽 갑옷", "궁수를 위한 가벼운 가죽 갑옷", 2000, new List<Job>{ Job.Archer }, new ExtraStat(37, 0, 0, 0, 9), EquipSlot.CHESTPLATE) },
            { 4201, new EquipItem("야생의 보호대", "자연 속에서 생존하는 사냥꾼의 갑옷", 4000, new List<Job>{ Job.Archer }, new ExtraStat(73, 0, 0, 0, 18), EquipSlot.CHESTPLATE) },
            { 4202, new EquipItem("지옥불의 갑옷", "지옥의 불길을 견뎌낸 단단한 가죽 갑옷", 8000, new List<Job>{ Job.Archer }, new ExtraStat(109, 0, 0, 0, 27), EquipSlot.CHESTPLATE) },
            { 4203, new EquipItem("정령의 수호 갑옷", "바람의 정령이 깃든 신비로운 방어구", 16000, new List<Job>{ Job.Archer }, new ExtraStat(146, 0, 0, 0, 36), EquipSlot.CHESTPLATE) },
            { 4204, new EquipItem("늑대 가죽 갑옷", "늑대의 기민함과 야성을 담은 방어구", 32000, new List<Job>{ Job.Archer }, new ExtraStat(182, 0, 0, 0, 45), EquipSlot.CHESTPLATE) },
            { 4205, new EquipItem("암석의 경갑", "골렘의 단단함을 본따 만든 방어구", 64000, new List<Job>{ Job.Archer }, new ExtraStat(219, 0, 0, 0, 54), EquipSlot.CHESTPLATE) },
            { 4206, new EquipItem("거인의 전투 갑옷", "거인족 전사들이 착용하던 전투용 방어구", 128000, new List<Job>{ Job.Archer }, new ExtraStat(255, 0, 0, 0, 63), EquipSlot.CHESTPLATE) },
            { 4207, new EquipItem("용비늘 갑옷", "용족의 비늘로 제작된 견고한 경갑", 256000, new List<Job>{ Job.Archer }, new ExtraStat(292, 0, 0, 0, 72), EquipSlot.CHESTPLATE) },
            { 4208, new EquipItem("고대 사냥꾼의 갑옷", "고대 궁수들이 사용하던 전설의 방어구", 512000, new List<Job>{ Job.Archer }, new ExtraStat(328, 0, 0, 0, 81), EquipSlot.CHESTPLATE) },
            { 4209, new EquipItem("신궁의 유산", "잊혀진 시대의 신궁들이 남긴 궁극의 갑옷", 1024000, new List<Job>{ Job.Archer }, new ExtraStat(365, 0, 0, 0, 90), EquipSlot.CHESTPLATE) },

            // 바지
            { 5000, new EquipItem("수습 전투 바지", "기본적인 전사 바지", 2000, new List<Job>{ Job.Warrior }, new ExtraStat(37, 0, 0, 0, 6), EquipSlot.LEGGINGS) },
            { 5001, new EquipItem("야생의 전투 바지", "야생에서 살아남은 전사들이 착용하는 튼튼한 바지", 4000, new List<Job>{ Job.Warrior }, new ExtraStat(73, 0, 0, 0, 12), EquipSlot.LEGGINGS) },
            { 5002, new EquipItem("지옥불의 전투 바지", "지옥불 속에서도 버틸 수 있도록 강화된 전투 바지", 8000, new List<Job>{ Job.Warrior }, new ExtraStat(110, 0, 0, 0, 18), EquipSlot.LEGGINGS) },
            { 5003, new EquipItem("정령의 보호 바지", "정령의 마법이 깃든 강력한 보호 바지", 16000, new List<Job>{ Job.Warrior }, new ExtraStat(147, 0, 0, 0, 24), EquipSlot.LEGGINGS) },
            { 5004, new EquipItem("늑대의 전투 바지", "늑대인간 전사들이 착용하는 민첩한 전투 바지", 32000, new List<Job>{ Job.Warrior }, new ExtraStat(183, 0, 0, 0, 30), EquipSlot.LEGGINGS) },
            { 5005, new EquipItem("골렘의 방어 바지", "골렘의 단단한 암석으로 제작된 방어 바지", 64000, new List<Job>{ Job.Warrior }, new ExtraStat(220, 0, 0, 0, 36), EquipSlot.LEGGINGS) },
            { 5006, new EquipItem("거인의 전투 바지", "거인족 전사들이 착용한 전투 바지", 128000, new List<Job>{ Job.Warrior }, new ExtraStat(257, 0, 0, 0, 42), EquipSlot.LEGGINGS) },
            { 5007, new EquipItem("용족의 전설 바지", "용족의 강력한 비늘로 제작된 전설적인 바지", 256000, new List<Job>{ Job.Warrior }, new ExtraStat(294, 0, 0, 0, 48), EquipSlot.LEGGINGS) },
            { 5008, new EquipItem("고대 전사들의 전투 바지", "고대 전사들이 착용했던 전설적인 전투 바지", 512000, new List<Job>{ Job.Warrior }, new ExtraStat(331, 0, 0, 0, 54), EquipSlot.LEGGINGS) },
            { 5009, new EquipItem("신화의 전투 바지", "신화 속 전사만이 입을 수 있는 궁극의 전투 바지", 1024000, new List<Job>{ Job.Warrior }, new ExtraStat(368, 0, 0, 0, 60), EquipSlot.LEGGINGS) },
            
            { 5100, new EquipItem("마법사의 기본 바지", "마법사의 기본적인 착용감을 제공하는 바지", 900, new List<Job>{ Job.Mage }, new ExtraStat(21, 0, 0, 0, 16), EquipSlot.LEGGINGS) },
            { 5101, new EquipItem("강철 마법 바지", "강철로 강화된 마법사의 튼튼한 바지", 1800, new List<Job>{ Job.Mage }, new ExtraStat(39, 0, 0, 0, 31), EquipSlot.LEGGINGS) },
            { 5102, new EquipItem("은빛 마법 바지", "은빛으로 장식된 우아한 마법사의 바지", 3600, new List<Job>{ Job.Mage }, new ExtraStat(57, 0, 0, 0, 46), EquipSlot.LEGGINGS) },
            { 5103, new EquipItem("황금 마법 바지", "황금으로 제작된 고급 마법사의 바지", 7200, new List<Job>{ Job.Mage }, new ExtraStat(75, 0, 0, 0, 61), EquipSlot.LEGGINGS) },
            { 5104, new EquipItem("용의 마법 바지", "고대 용의 마법이 담긴 마법사의 전설적인 바지", 14400, new List<Job>{ Job.Mage }, new ExtraStat(93, 0, 0, 0, 76), EquipSlot.LEGGINGS) },
            { 5105, new EquipItem("백금 마법 바지", "백금으로 만든 궁극의 마법사 전용 바지", 28800, new List<Job>{ Job.Mage }, new ExtraStat(111, 0, 0, 0, 91), EquipSlot.LEGGINGS) },
            { 5106, new EquipItem("천상의 마법 바지", "천사의 축복을 받은 신성한 마법사의 바지", 57600, new List<Job>{ Job.Mage }, new ExtraStat(129, 0, 0, 0, 106), EquipSlot.LEGGINGS) },
            { 5107, new EquipItem("심연의 마법 바지", "심연의 어둠을 품은 마법사의 바지", 115200, new List<Job>{ Job.Mage }, new ExtraStat(147, 0, 0, 0, 121), EquipSlot.LEGGINGS) },
            { 5108, new EquipItem("불사의 마법 바지", "불사의 힘을 부여받은 불멸의 마법사의 바지", 230400, new List<Job>{ Job.Mage }, new ExtraStat(165, 0, 0, 0, 136), EquipSlot.LEGGINGS) },
            { 5109, new EquipItem("신의 마법 바지", "신의 권능이 깃든 신비로운 마법사의 바지", 460800, new List<Job>{ Job.Mage }, new ExtraStat(183, 0, 0, 0, 151), EquipSlot.LEGGINGS) },

            { 5200, new EquipItem("초보 사냥꾼의 바지", "궁수를 위한 가벼운 가죽 바지", 1500, new List<Job>{ Job.Archer }, new ExtraStat(27, 0, 0, 0, 6), EquipSlot.LEGGINGS) },
            { 5201, new EquipItem("야생의 헌터 팬츠", "자연 속에서 살아남기 위한 튼튼한 바지", 3000, new List<Job>{ Job.Archer }, new ExtraStat(55, 0, 0, 0, 12), EquipSlot.LEGGINGS) },
            { 5202, new EquipItem("지옥불의 다리 보호대", "지옥의 불길 속에서도 타지 않는 바지", 6000, new List<Job>{ Job.Archer }, new ExtraStat(82, 0, 0, 0, 18), EquipSlot.LEGGINGS) },
            { 5203, new EquipItem("정령의 하의", "바람의 정령이 깃든 신비로운 하의", 12000, new List<Job>{ Job.Archer }, new ExtraStat(110, 0, 0, 0, 24), EquipSlot.LEGGINGS) },
            { 5204, new EquipItem("늑대 가죽 바지", "늑대의 날렵함을 닮은 사냥꾼의 하의", 24000, new List<Job>{ Job.Archer }, new ExtraStat(137, 0, 0, 0, 30), EquipSlot.LEGGINGS) },
            { 5205, new EquipItem("암석의 경갑", "골렘의 단단함을 본따 만든 다리 보호구", 48000, new List<Job>{ Job.Archer }, new ExtraStat(164, 0, 0, 0, 36), EquipSlot.LEGGINGS) },
            { 5206, new EquipItem("거인의 전투 바지", "거인족이 사용하던 강력한 방어구", 96000, new List<Job>{ Job.Archer }, new ExtraStat(192, 0, 0, 0, 42), EquipSlot.LEGGINGS) },
            { 5207, new EquipItem("용비늘 경갑", "용족의 비늘로 제작된 강력한 방어구", 192000, new List<Job>{ Job.Archer }, new ExtraStat(219, 0, 0, 0, 48), EquipSlot.LEGGINGS) },
            { 5208, new EquipItem("고대 사냥꾼의 바지", "고대 궁수들이 사용하던 전설의 하의", 384000, new List<Job>{ Job.Archer }, new ExtraStat(247, 0, 0, 0, 54), EquipSlot.LEGGINGS) },
            { 5209, new EquipItem("신궁의 유산", "잊혀진 시대의 신궁들이 남긴 궁극의 바지", 768000, new List<Job>{ Job.Archer }, new ExtraStat(274, 0, 0, 0, 60), EquipSlot.LEGGINGS) },

            // 신발
            { 6000, new EquipItem("수습 전투 신발", "기본적인 전사 신발", 2000, new List<Job>{ Job.Warrior }, new ExtraStat(18, 0, 0, 0, 3), EquipSlot.BOOTS) },
            { 6001, new EquipItem("야생의 전투 신발", "야생에서 살아남은 전사들이 착용하는 튼튼한 신발", 4000, new List<Job>{ Job.Warrior }, new ExtraStat(36, 0, 0, 0, 6), EquipSlot.BOOTS) },
            { 6002, new EquipItem("지옥불의 전투 신발", "지옥불 속에서도 버틸 수 있도록 강화된 전투 신발", 8000, new List<Job>{ Job.Warrior }, new ExtraStat(54, 0, 0, 0, 9), EquipSlot.BOOTS) },
            { 6003, new EquipItem("정령의 보호 신발", "정령의 마법이 깃든 강력한 보호 신발", 16000, new List<Job>{ Job.Warrior }, new ExtraStat(72, 0, 0, 0, 12), EquipSlot.BOOTS) },
            { 6004, new EquipItem("늑대의 전투 신발", "늑대인간 전사들이 착용하는 민첩한 전투 신발", 32000, new List<Job>{ Job.Warrior }, new ExtraStat(90, 0, 0, 0, 15), EquipSlot.BOOTS) },
            { 6005, new EquipItem("골렘의 방어 신발", "골렘의 단단한 암석으로 제작된 방어 신발", 64000, new List<Job>{ Job.Warrior }, new ExtraStat(108, 0, 0, 0, 18), EquipSlot.BOOTS) },
            { 6006, new EquipItem("거인의 전투 신발", "거인족 전사들이 착용한 전투 신발", 128000, new List<Job>{ Job.Warrior }, new ExtraStat(126, 0, 0, 0, 21), EquipSlot.BOOTS) },
            { 6007, new EquipItem("용족의 전설 신발", "용족의 강력한 비늘로 제작된 전설적인 신발", 256000, new List<Job>{ Job.Warrior }, new ExtraStat(144, 0, 0, 0, 24), EquipSlot.BOOTS) },
            { 6008, new EquipItem("고대 전사들의 전투 신발", "고대 전사들이 착용했던 전설적인 전투 신발", 512000, new List<Job>{ Job.Warrior }, new ExtraStat(162, 0, 0, 0, 27), EquipSlot.BOOTS) },
            { 6009, new EquipItem("신화의 전투 신발", "신화 속 전사만이 입을 수 있는 궁극의 전투 신발", 1024000, new List<Job>{ Job.Warrior }, new ExtraStat(180, 0, 0, 0, 30), EquipSlot.BOOTS) },
            
            { 6100, new EquipItem("마법사의 기본 신발", "마법사들이 착용하는 기본적인 신발", 900, new List<Job>{ Job.Mage }, new ExtraStat(11, 0, 0, 0, 8), EquipSlot.BOOTS) },
            { 6101, new EquipItem("강철 마법 신발", "강철로 강화된 마법사의 튼튼한 신발", 1800, new List<Job>{ Job.Mage }, new ExtraStat(20, 0, 0, 0, 16), EquipSlot.BOOTS) },
            { 6102, new EquipItem("은빛 마법 신발", "은빛으로 장식된 우아한 마법사의 신발", 3600, new List<Job>{ Job.Mage }, new ExtraStat(29, 0, 0, 0, 23), EquipSlot.BOOTS) },
            { 6103, new EquipItem("황금 마법 신발", "황금으로 만들어진 고급 마법사의 신발", 7200, new List<Job>{ Job.Mage }, new ExtraStat(38, 0, 0, 0, 31), EquipSlot.BOOTS) },
            { 6104, new EquipItem("용의 마법 신발", "고대 용의 마법이 깃든 마법사의 전설적인 신발", 14400, new List<Job>{ Job.Mage }, new ExtraStat(47, 0, 0, 0, 38), EquipSlot.BOOTS) },
            { 6105, new EquipItem("백금 마법 신발", "백금으로 제작된 궁극의 마법사 전용 신발", 28800, new List<Job>{ Job.Mage }, new ExtraStat(56, 0, 0, 0, 46), EquipSlot.BOOTS) },
            { 6106, new EquipItem("천상의 마법 신발", "천사의 축복을 받은 신성한 마법사의 신발", 57600, new List<Job>{ Job.Mage }, new ExtraStat(65, 0, 0, 0, 53), EquipSlot.BOOTS) },
            { 6107, new EquipItem("심연의 마법 신발", "어둠의 마법을 품은 마법사의 신발", 115200, new List<Job>{ Job.Mage }, new ExtraStat(74, 0, 0, 0, 61), EquipSlot.BOOTS) },
            { 6108, new EquipItem("불사의 마법 신발", "불사의 힘을 부여받은 불멸의 마법사의 신발", 230400, new List<Job>{ Job.Mage }, new ExtraStat(83, 0, 0, 0, 68), EquipSlot.BOOTS) },
            { 6109, new EquipItem("신의 마법 신발", "신의 권능이 깃든 신비로운 마법사의 신발", 460800, new List<Job>{ Job.Mage }, new ExtraStat(92, 0, 0, 0, 76), EquipSlot.BOOTS) },

            { 6200, new EquipItem("수습 가죽 신발", "궁수를 위한 기본적인 가죽 신발", 1200, new List<Job>{ Job.Archer }, new ExtraStat(14, 0, 0, 0, 3), EquipSlot.BOOTS) },
            { 6201, new EquipItem("야생의 사냥꾼 부츠", "야생에서 적응한 사냥꾼들의 신발", 2400, new List<Job>{ Job.Archer }, new ExtraStat(27, 0, 0, 0, 6), EquipSlot.BOOTS) },
            { 6202, new EquipItem("지옥불의 전투화", "지옥의 불길에서도 녹지 않는 신발", 4800, new List<Job>{ Job.Archer }, new ExtraStat(41, 0, 0, 0, 9), EquipSlot.BOOTS) },
            { 6203, new EquipItem("정령의 신속화", "바람의 정령이 깃든 신비로운 신발", 9600, new List<Job>{ Job.Archer }, new ExtraStat(55, 0, 0, 0, 12), EquipSlot.BOOTS) },
            { 6204, new EquipItem("늑대 가죽 장화", "늑대의 날렵함과 기동성을 담은 신발", 19200, new List<Job>{ Job.Archer }, new ExtraStat(68, 0, 0, 0, 15), EquipSlot.BOOTS) },
            { 6205, new EquipItem("암석의 부츠", "골렘의 단단함을 본따 만든 방어구", 38400, new List<Job>{ Job.Archer }, new ExtraStat(82, 0, 0, 0, 18), EquipSlot.BOOTS) },
            { 6206, new EquipItem("거인의 전투 신발", "거인의 강력한 발을 보호하는 튼튼한 신발", 76800, new List<Job>{ Job.Archer }, new ExtraStat(96, 0, 0, 0, 21), EquipSlot.BOOTS) },
            { 6207, new EquipItem("용비늘 경화 장화", "용족의 비늘로 제작된 강력한 신발", 153600, new List<Job>{ Job.Archer }, new ExtraStat(109, 0, 0, 0, 24), EquipSlot.BOOTS) },
            { 6208, new EquipItem("고대 사냥꾼의 장화", "고대 궁수들이 사용하던 전설적인 신발", 307200, new List<Job>{ Job.Archer }, new ExtraStat(123, 0, 0, 0, 27), EquipSlot.BOOTS) },
            { 6209, new EquipItem("신궁의 유산", "잊혀진 시대의 신궁들이 남긴 궁극의 신발", 614400, new List<Job>{ Job.Archer }, new ExtraStat(137, 0, 0, 0, 30), EquipSlot.BOOTS) },

            // 액세서리
            { 7000, new EquipItem("수습 전사 악세서리", "기본적인 전사 악세서리", 2000, new List<Job>{ Job.Warrior }, new ExtraStat(30, 163, 108, 76, 5), EquipSlot.ACCESSORY) },
            { 7001, new EquipItem("야생의 전사 악세서리", "전사들이 착용했었다", 4000, new List<Job>{ Job.Warrior }, new ExtraStat(60, 326, 216, 152, 10), EquipSlot.ACCESSORY) },
            { 7002, new EquipItem("지옥불 악세서리", "지옥불로 만들었다", 8000, new List<Job>{ Job.Warrior }, new ExtraStat(90, 489, 324, 228, 15), EquipSlot.ACCESSORY) },
            { 7003, new EquipItem("정령의 악세서리", "정령으로 만들었다", 16000, new List<Job>{ Job.Warrior }, new ExtraStat(120, 652, 432, 304, 20), EquipSlot.ACCESSORY) },
            { 7004, new EquipItem("늑대인간 악세서리", "늑대인간이 착용했었다", 32000, new List<Job>{ Job.Warrior }, new ExtraStat(150, 815, 540, 380, 25), EquipSlot.ACCESSORY) },
            { 7005, new EquipItem("전투 골렘 악세서리", "골렘으로 만들었다", 64000, new List<Job>{ Job.Warrior }, new ExtraStat(180, 978, 648, 456, 30), EquipSlot.ACCESSORY) },
            { 7006, new EquipItem("거인의 전사 악세서리", "힘의 악세서리", 128000, new List<Job>{ Job.Warrior }, new ExtraStat(210, 1141, 756, 532, 35), EquipSlot.ACCESSORY) },
            { 7007, new EquipItem("전투 용족 악세서리", "비늘로 만들었다", 256000, new List<Job>{ Job.Warrior }, new ExtraStat(240, 1304, 864, 608, 40), EquipSlot.ACCESSORY) },
            { 7008, new EquipItem("고대 전사 악세서리", "전설적인 악세서리", 512000, new List<Job>{ Job.Warrior }, new ExtraStat(270, 1467, 972, 684, 45), EquipSlot.ACCESSORY) },
            { 7009, new EquipItem("신화의 전사 악세서리", "신화 악세서리", 1024000, new List<Job>{ Job.Warrior }, new ExtraStat(300, 1630, 1080, 760, 50), EquipSlot.ACCESSORY) },

            { 7100, new EquipItem("수습 마법사 악세서리", "기본적인 마법사 악세서리", 2000, new List<Job>{ Job.Mage }, new ExtraStat(18, 17, 0, 29, 29), EquipSlot.ACCESSORY) },
            { 7101, new EquipItem("야생의 마법사 악세서리", "마법을 연마한 마법사 악세서리", 4000, new List<Job>{ Job.Mage }, new ExtraStat(33, 32, 0, 56, 56), EquipSlot.ACCESSORY) },
            { 7102, new EquipItem("지옥불의 마법사 악세서리", "지옥불로 만들었다", 8000, new List<Job>{ Job.Mage }, new ExtraStat(48, 47, 0, 83, 83), EquipSlot.ACCESSORY) },
            { 7103, new EquipItem("정령의 보호 악세서리", "정령의 마법으로 만들었다", 16000, new List<Job>{ Job.Mage }, new ExtraStat(63, 62, 0, 110, 110), EquipSlot.ACCESSORY) },
            { 7104, new EquipItem("늑대인간 마법 악세서리", "늑대인간 마법사들이 착용했었다", 32000, new List<Job>{ Job.Mage }, new ExtraStat(78, 77, 0, 137, 137), EquipSlot.ACCESSORY) },
            { 7105, new EquipItem("마법 골렘 악세서리", "골렘으로 만들었다", 64000, new List<Job>{ Job.Mage }, new ExtraStat(93, 92, 0, 164, 164), EquipSlot.ACCESSORY) },
            { 7106, new EquipItem("거인의 마법사 악세서리", "거인들이 착용했었다", 128000, new List<Job>{ Job.Mage }, new ExtraStat(108, 107, 0, 191, 191), EquipSlot.ACCESSORY) },
            { 7107, new EquipItem("용족의 마법 악세서리", "용족의 비늘로 제작되었다", 256000, new List<Job>{ Job.Mage }, new ExtraStat(123, 122, 0, 218, 218), EquipSlot.ACCESSORY) },
            { 7108, new EquipItem("고대 마법사 악세서리", "고대 마법사들이 착용했었다", 512000, new List<Job>{ Job.Mage }, new ExtraStat(138, 137, 0, 245, 245), EquipSlot.ACCESSORY) },
            { 7109, new EquipItem("신화의 마법사 악세서리", "신화 악세서리", 1024000, new List<Job>{ Job.Mage }, new ExtraStat(153, 152, 0, 272, 272), EquipSlot.ACCESSORY) },

            { 7200, new EquipItem("수습 활반지", "궁수를 위한 기본적인 반지", 1800, new List<Job>{ Job.Archer }, new ExtraStat(23, 8, 11, 0, 11), EquipSlot.ACCESSORY) },
            { 7201, new EquipItem("야생의 펜던트", "야생에서 적응한 사냥꾼들이 애용하는 펜던트", 3600, new List<Job>{ Job.Archer }, new ExtraStat(46, 16, 22, 0, 22), EquipSlot.ACCESSORY) },
            { 7202, new EquipItem("지옥불의 룬 목걸이", "강력한 룬이 새겨진 목걸이", 7200, new List<Job>{ Job.Archer }, new ExtraStat(68, 25, 33, 0, 33), EquipSlot.ACCESSORY) },
            { 7203, new EquipItem("정령의 귀걸이", "정령의 힘이 깃든 신비로운 귀걸이", 14400, new List<Job>{ Job.Archer }, new ExtraStat(91, 34, 44, 0, 44), EquipSlot.ACCESSORY) },
            { 7204, new EquipItem("늑대의 발톱 펜던트", "늑대의 발톱으로 만들었다", 28800, new List<Job>{ Job.Archer }, new ExtraStat(114, 42, 55, 0, 55), EquipSlot.ACCESSORY) },
            { 7205, new EquipItem("암석의 수호 반지", "골렘의 수호 반지", 57600, new List<Job>{ Job.Archer }, new ExtraStat(137, 51, 66, 0, 66), EquipSlot.ACCESSORY) },
            { 7206, new EquipItem("거인의 망토", "거인의 힘이 깃든 견고한 망토", 115200, new List<Job>{ Job.Archer }, new ExtraStat(160, 59, 77, 0, 77), EquipSlot.ACCESSORY) },
            { 7207, new EquipItem("용비늘 브로치", "용족의 비늘로 제작된 강력한 브로치", 230400, new List<Job>{ Job.Archer }, new ExtraStat(182, 68, 88, 0, 88), EquipSlot.ACCESSORY) },
            { 7208, new EquipItem("고대 사냥꾼의 인장", "고대 궁수들이 사용하던 인장", 460800, new List<Job>{ Job.Archer }, new ExtraStat(205, 76, 99, 0, 99), EquipSlot.ACCESSORY) },
            { 7209, new EquipItem("신궁의 유산", "잊혀진 시대의 궁극의 악세서리", 921600, new List<Job>{ Job.Archer }, new ExtraStat(228, 85, 109, 0, 108), EquipSlot.ACCESSORY) },
        };

        public EquipItem GetByKey(int key)
        {
            if (equipItems.ContainsKey(key))
            {
                return equipItems[key].Clone() as EquipItem;
            }
            return null;
        }
    };
}
