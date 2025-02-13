using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Items;
using DungeonTRPG.Manager;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.EntitySystem
{

    internal abstract class Character
    {
        public string Name { get; protected set; }
        public int Gold { get; protected set; }
        public Stat Stat { get; protected set; }
        public Inventory Inventory { get; protected set; }
        public CharacterState CharacterState { get; protected set; }
        public List<int> Skills { get; protected set; } = new List<int>();

        public bool isDead { get; private set; } = false;

        public event Action<Character, Character, int>? OnAttack;
        public event Action<Character, int>? OnDamage;
        public event Action<Character, int>? OnHeal;
        public event Action<Character>? OnCharacterDie;

        public Character(string name, int gold, Stat stat)
        {            
            Name = name;
            Gold = gold;
            Stat = stat;
            Inventory = new Inventory(this);
            CharacterState = new CharacterState();

            Stat.CharacterDie += CharacterDie;
        }

        public Character(string name, int gold, Stat stat, List<int> IndexSkill)
        {
            Name = name;
            Gold = gold;
            Stat = stat;
            Inventory = new Inventory(this);
            CharacterState = new CharacterState();

            Skills = IndexSkill;

            Stat.CharacterDie += CharacterDie;
        }

        private void CharacterDie()
        {
            isDead = true;
            OnCharacterDie?.Invoke(this);
        }

        internal void OnItemEquipped(EquipItem item)
        {
            Stat.SetMaxHp(Stat.MaxHp + item.ExtraStat.Hp);
            Stat.SetMaxMp(Stat.MaxMp + item.ExtraStat.Mp);
            Stat.SetAtk(Stat.Atk + item.ExtraStat.Atk);
            Stat.SetDef(Stat.Def + item.ExtraStat.Def);
        }

        internal void OnItemUnEquipped(EquipItem item)
        {
            Stat.SetMaxHp(Stat.MaxHp - item.ExtraStat.Hp);
            Stat.SetHp(Stat.MaxHp);
            Stat.SetMaxMp(Stat.MaxMp - item.ExtraStat.Mp);
            Stat.SetMp(Stat.MaxMp);
            Stat.SetAtk(Stat.Atk - item.ExtraStat.Atk);
            Stat.SetDef(Stat.Def - item.ExtraStat.Def);
        }

        // 공격
        public int Attack(Character target)
        {
            int damage = Stat.Atk > Stat.SpellAtk ? Stat.Atk : Stat.SpellAtk;
            
            if (damage < 0) damage = 0;
            damage = target.Stat.TakeDamage(damage);

            return damage;
        }

        // 피격
        public int Damaged(int damage)
        {
            int result = Stat.TakeDamage(damage);
            return result;
        }

        public int TrueDamaged(int damage)
        {
            int result = Stat.TakeTrueDamage(damage);
            return result;
        }

        // 체력 회복
        public int Heal(int amount)
        {
            Stat.SetHp(Stat.Hp + amount);
            return amount;
        }

        // 마나 사용
        public void UseMana(int amount)
        {
            Stat.SetMp(Stat.Mp - amount);
        }

        // 마나 회복
        public int RecoverMana(int amount)
        {
            Stat.SetMp(Stat.Mp + amount);
            return amount;
        }

        public int LearnSkill(int skillNum)
        {
            if(Skills.Contains(skillNum)) return 0;
            Skills.Add(skillNum);
            return 1;
        }

        // 골드 차감
        public bool SpendGold(int amount)
        {
            if (Gold >= amount)
            {
                Gold -= amount;
                return true;  
            }
            return false; 
        }

        public void EarnGold(int amount)
        {
            if (amount > 0)
            {
                Gold += amount;
            }
        }

        public abstract Character Clone();
    }
}
