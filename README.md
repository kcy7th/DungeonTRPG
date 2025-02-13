# 🏰 LABYRINTH of FATE
플레이어가 던전을 탐험하며 몬스터를 처치하고, 아이템을 획득하거나 상점을 이용하여 장비를 강화하는 **텍스트 기반의 턴제 RPG 게임**입니다!

---

## 📂 프로젝트 구조
📦 DungeonTRPG

 ┣ 📂 EntitySystem          # 캐릭터 및 전투 관련 시스템

 ┃ ┣ 📜 Character.cs        # 기본 캐릭터 클래스

 ┃ ┣ 📜 Player.cs           # 플레이어 클래스

 ┃ ┣ 📜 Enemy.cs            # 적 클래스

 ┣ 📂 Items                 # 아이템 관련 코드

 ┃ ┣ 📜 Item.cs             # 기본 아이템 클래스

 ┃ ┣ 📜 EquipItem.cs        # 장비 아이템 클래스

 ┃ ┣ 📜 ActiveItem.cs       # 소비 아이템 클래스

 ┣ 📂 Manager               # 게임 관리 시스템

 ┃ ┣ 📜 GameManager.cs      # 게임 진행 관리

 ┃ ┣ 📜 DataManager.cs      # 데이터 저장 및 로드

 ┣ 📂 ShopSystem            # 상점 시스템

 ┃ ┣ 📜 Shop.cs             # 일반 상점 로직

 ┃ ┣ 📜 SecretShop.cs       # 비밀 상점 로직

 ┣ 📂 StateMachineSystem    # 상태 머신 시스템

 ┃ ┣ 📜 StateMachine.cs     # 게임 씬 관리

 ┃ ┣ 📜 DungeonScene.cs     # 던전 탐험 씬

 ┃ ┣ 📜 CombatScene.cs      # 전투 씬

 ┃ ┣ 📜 InventoryScene.cs   # 인벤토리 씬

 ┃ ┣ 📜 ShopScene.cs        # 일반 상점 씬

 ┃ ┣ 📜 SecretShopScene.cs  # 비밀 상점 씬

 ┃ ┣ 📜 SellScene.cs        # 아이템 판매 씬

 ┣ 📜 Program.cs            # 게임 시작점

 ┣ 📜 DungeonTRPG.sln       # Visual Studio 솔루션 파일

---

## ⚙ 주요 시스템
**🏹 전투 시스템 (CombatScene.cs)**
- 턴제 전투 시스템 구현
- 플레이어와 적이 번갈아 가며 공격
- 스킬 및 아이템 사용 가능

**🏰 던전 탐험 시스템 (DungeonScene.cs)**
- 랜덤 이벤트 발생 (전투, 상점, 휴식, 랜덤 상자 등)
- 탐험 시 다양한 보상 획득 가능
- 탐험 시 경험치 획득

**🛒 상점 시스템 (ShopScene.cs, SecretShopScene.cs)**
- 일반 상점 & 비밀 상점 운영
- 비밀 상점에서는 특별한 아이템 구매 가능
- 아이템 판매 시 80% 가격으로 골드 획득

**🎒 인벤토리 시스템 (InventoryScene.cs)**
- 보유 아이템 확인
- 장비 장착 / 해제 가능
- 소비 아이템 사용 가능

---

## 🏆 특별한 기능 목록

| 기능 | 설명 |
|------|------|
| **🛒 비밀 상점** | 던전 탐험 중 **랜덤하게 등장**하는 숨겨진 상점. 희귀한 소비 아이템과 장비 구매 가능 |
| **🏕 휴식 공간** | 던전에서 발견할 수 있는 안전 구역. 체력과 마나를 일부 회복할 수 있음 |
| **🎁 의문의 상자** | 던전 탐험 중 랜덤하게 발견. 열었을 때 **골드, 아이템 또는 함정**이 나올 수 있음 |
| **⚔ 공격 시스템** | 플레이어와 적이 **턴제 전투 방식**으로 공격을 주고받음 |
| **🔥 스킬 시스템** | 100개 이상의 다양한 **공격, 버프, 디버프 스킬**을 사용할 수 있음 |
| **🛡 방어 시스템** | 턴마다 방어 선택 가능. 방어 시 받는 피해가 감소함 |
| **🎮 스테이지 시스템** | 던전은 **층 단위(1층~100층)로 구성**. 점점 강한 적이 등장 |
| **👹 보스 몬스터** | 특정 층마다 강력한 **보스 몬스터**가 등장하며, 패턴을 분석하여 공략 필요 |
| **🎯 던전 100층** | 최종 목표는 **100층을 정복**하는 것! 최종 보스를 처치하면 게임 클리어 |
| **💰 몬스터 처치 보상** | 몬스터를 처치하면 **골드와 경험치 보상**을 획득하여 캐릭터 성장 가능 |
| **🛠 100가지 이상의 스킬 & 아이템** | 다양한 스킬과 장비를 활용하여 전략적인 전투 진행 가능 |

---

## 🎮 게임 플레이 가이드
**1️⃣ 캐릭터 선택**
- 전사(Warrior): 강한 공격력과 높은 체력
- 마법사(Mage): 강력한 마법 공격과 마나 회복
- 궁수(Archer): 빠른 공격 속도와 높은 명중률

**2️⃣ 던전 탐험**
- 랜덤 이벤트 종류
    - 몬스터 조우 🐉
    - 휴식 공간 🏕 (체력/마나 회복)
    - 비밀 상점 🛒 (특별한 아이템 구매 가능)
    - 의문의 상자 🎁 (랜덤 아이템 획득)

**3️⃣ 전투 시스템**
- 턴제 전투 진행
- 스킬 & 아이템 사용 가능
- 전투 승리 시 경험치와 골드 획득
- 체력 0이 되면 게임 종료

**4️⃣ 상점 시스템**
**🛒 일반 상점**
- ShopScene.cs
- 일반적인 소비 아이템 및 장비 구매 가능

**🛒 비밀 상점**
- SecretShopScene.cs
- 희귀 소비 아이템 구매 가능 (랜덤 등장)

**💰 아이템 판매**
- SellScene.cs
- 보유 아이템 80% 가격으로 판매 가능
- 판매 시 골드 획득

---

### 🎯 전략적인 플레이를 위한 팁!
- **💡 던전을 탐험하세요!**  
  → 희귀 아이템을 구할 수 있는 기회!

- **🩸 체력 관리가 필수!**  
  → **휴식 공간을 발견하면 이용**하여 HP와 MP를 회복하세요.  

- **🎲 의문의 상자는 신중하게!**  
  → 좋은 아이템이 나올 수도 있지만, 함정이 있을 수도 있으니 주의하세요.  

- **⚔️ 스킬을 적극적으로 활용하세요**  
  → 일반 공격만으로는 강한 적을 상대하기 어려울 수 있습니다.  
  
- **🏆 보스 몬스터 공략법을 파악하세요**  
  → 생각보다 강할 지도?  

---