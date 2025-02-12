using DungeonTRPG.Utility.Enums;

namespace DungeonTRPG.Items
{
    public abstract class Item : IComparable<Item>
    {
        protected string name;
        protected string description;
        public int Price { get; private set; }
        protected List<Job> allowedJobs;

        public List<Job> AllowedJobs => allowedJobs;

        public Item(string name, string description, int price, List<Job>? allowedJobs = null)
        {
            this.name = name;
            this.description = description;
            this.Price = price;
            this.allowedJobs = allowedJobs ?? new List<Job>();
        }

        public string GetName() => name;
        public string GetDescription() => description;

        // 해당 직업이 아이템을 사용할 수 있는지 확인
        public bool CanUse(Job job) => allowedJobs.Contains(job);

        // 아이템 복제
        public abstract Item Clone();

        public abstract int CompareTo(Item? other);

        public virtual string GetItemInformation()
        {
            return $"{name} | {description}";
        }

        public bool isAllowedJob(Job job)
        {
            foreach(Job item in allowedJobs)
            {
                if(item == job || item == Job.None) return true;
            }
            return false;
        }

        public string AllowedJobToString()
        {
            string str = "";

            foreach (Job job in allowedJobs)
            {
                str += job + " ";
            }

            return str;
        }
    }
}
