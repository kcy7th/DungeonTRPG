using DungeonTRPG.Entity.Utility;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.EntitySystem.Utility;
using DungeonTRPG.Items;

namespace DungeonTRPG.Entity
{

    internal abstract class Character
    {
        public string Name { get; protected set; }
        public int Gold { get; protected set; }
        public Stat Stat { get; protected set; }
        public Inventory Inventory { get; protected set; }
        public CharacterState CharacterState { get; protected set; }
        public List<Skill> Skills { get; protected set; } = new List<Skill>();

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
            Stat.SetMaxMp(Stat.MaxMp - item.ExtraStat.Mp);
            Stat.SetAtk(Stat.Atk - item.ExtraStat.Atk);
            Stat.SetDef(Stat.Def - item.ExtraStat.Def);
        }

        // 공격
        public void Attack(Character target)
        {
            int damage = Stat.Atk;
            if (damage < 0) damage = 0;
            damage = target.Stat.TakeDamage(damage);
            OnAttack?.Invoke(this, target, damage);
        }

        // 피격
        public int Damaged(int damage)
        {
            int result = Stat.TakeDamage(damage);
            OnDamage?.Invoke(this, result);
            return result;
        }

        public int TrueDamaged(int damage)
        {
            int result = Stat.TakeTrueDamage(damage);
            OnDamage?.Invoke(this, result);
            return result;
        }

        // 체력 회복
        public void Heal(int amount)
        {
            Stat.SetHp(Stat.Hp + amount);
            OnHeal?.Invoke(this, amount);
        }

        // 마나 사용
        public void UseMana(int amount)
        {
            Stat.SetMp(Stat.Mp - amount);
        }

        // 마나 회복
        public void RecoverMana(int amount)
        {
            Stat.SetMp(Stat.Mp + amount);
        }

        public void LearnSkill(Skill skill)
        {
            if(Skills.Contains(skill)) return;
            Skills.Add(skill);
        }
    }
}
