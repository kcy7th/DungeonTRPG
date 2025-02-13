using DungeonTRPG.EntitySystem;
using DungeonTRPG.EntitySystem.SkillSystem;
using DungeonTRPG.Manager;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.StateMachineSystem.SceneStates.Combat
{
    internal class EnemyTurnScene : CombatScene
    {
        private Enemy enemy;

        public EnemyTurnScene(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Console.Title = "EnemyTurn";

            foreach (Enemy enemy in stateMachine.enemys)
            {
                enemy.OnCharacterDie += CharacterDead;
            }

            player.OnCharacterDie += CharacterDead;
        }

        public override void Exit()
        {
            base.Exit();

            foreach (Enemy enemy in stateMachine.enemys)
            {
                enemy.OnCharacterDie -= CharacterDead;

                enemy.CharacterState.TurnCountDown();
            }

            player.OnCharacterDie -= CharacterDead;

            player.CharacterState.TurnCountDown();
        }

        protected override void View()
        {
            EnemyStats();
        }

        protected override void Control()
        {
            if (!CheckState()) return;

            int random = Random.Next(0, 101);

            
            if (random < 20)
            {
                random = Random.Next(0, enemy.Skills.Count);
                int key = enemy.Skills[random];
                Skill skill = GameManager.Instance.DataManager.GameData.SkillDB.GetByKey(key);
                if(enemy.Stat.Mp >= skill.cost)
                {
                    UseSkill(enemy, skill.name);
                    int damage = skill.UseSkill(enemy, new List<Character>() { player });
                    if (damage > 0) Damage(player, damage);
                }
                else
                {
                    int damage = enemy.Attack(player);
                    Attack(enemy, player, damage);
                }
            }
            else if (random < 101 || enemy.Skills.Count < 1)
            {
                int damage = enemy.Attack(player);
                Attack(enemy, player, damage);
            }

            Thread.Sleep(stateMachine.tick);
        }

        private bool CheckState()
        {
            if (stateMachine.enemyTurnCount < stateMachine.enemys.Count)
            {
                enemy = stateMachine.enemys[stateMachine.enemyTurnCount];

                stateMachine.enemyTurnCount++;

                if (!enemy.isDead)
                {
                    switch (enemy.CharacterState.State)
                    {
                        case State.Sleep:
                            Sleep(enemy);
                            return false;
                        case State.Poison:
                        case State.Burn:
                            Addiction(enemy);
                            enemy.TrueDamaged(enemy.Stat.MaxHp / 10);
                            break;
                        case State.Confusion:
                            Confusion(enemy);
                            break;
                    }
                }
                else return false;
            }
            else
            {
                int count = 0;
                foreach (Enemy enemy in stateMachine.enemys)
                {
                    if (enemy.isDead) count++;
                }

                if (count == stateMachine.enemys.Count) stateMachine.ChangeState(new PlayerWinScene(stateMachine));
                else stateMachine.ChangeState(new PlayerTurnScene(stateMachine));

                return false;
            }

            return true;
        }
    }
}
