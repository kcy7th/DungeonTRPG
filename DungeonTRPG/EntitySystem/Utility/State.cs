using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonTRPG.EntitySystem.Utility
{
    public enum State
    {
        addiction, // 중독: 도트 데미지
        sleep, // 수면: 턴 패스
        Confusion, // 혼란: 공격 시 미스
    }
}
