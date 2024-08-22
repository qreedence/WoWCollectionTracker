using System.Numerics;

namespace SharedModels.Models
{
    public class CharacterAchievementData
    {
        public int total_quantity { get; set; }
        public int total_points { get; set; }

        public List<AchievementListItem> achievements { get; set; }
    }

    public class AchievementListItem
    {
        public int id { get; set; }
        public AchievementChildObject achievement { get; set; }
        public CharacterCriteria criteria { get; set; }
        public long completed_timestamp { get; set; }
    }

    public class AchievementChildObject 
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class CriteriaChild
    {
        public int id { get; set; }
        public bool is_completed { get; set; }
    }

    public class CriteriaGrandChild 
    { 
        public int id { get; set; }
        public BigInteger amount { get; set; }
        public bool is_completed { get; set; }
    }
}