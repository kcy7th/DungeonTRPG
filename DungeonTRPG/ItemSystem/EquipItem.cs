using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Item
{
    internal class EquipItem : Item
    {
        // 착용 가능한 직업 목록
        private List<Job> allowedJobs;

        public EquipItem(string name, string description, List<Job> allowedJobs)
            : base(name, description)
        {
            this.allowedJobs = allowedJobs;
        }

        // 착용 가능 여부 
        public bool CanEquip(Job job)
        {
            return allowedJobs.Contains(job);
        }

        public override Item Clone()
        {
            return new EquipItem(name, description, new List<Job>(allowedJobs));
        }
    }
}
