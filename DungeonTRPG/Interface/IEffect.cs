using DungeonTRPG.EntitySystem;

namespace DungeonTRPG.Interface
{
    //스킬 효과가 상속할 스킬 인터페이스
    internal interface IEffect
    {
        int UseEffect(Character player, List<Character> targets);
    }
}
