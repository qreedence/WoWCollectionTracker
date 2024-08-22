using System.Numerics;

namespace SharedModels.Models
{
    public class Achievement
    {
        public Links _links { get; set; }
        public int Id { get; set; }
        public Category category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public bool IsAccountWide { get; set; }
        public Criteria criteria { get; set; }
        public Achievement NextAchievement { get; set; }
        public Media Media { get; set; }
        public int display_order { get; set; }

        public string Patch { get; set; }
        public string SubCategory { get; set; }
        public MediaObject MediaObject { get; set; }
    }

    public class Category
    {
        public Key Key { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }


    public class Criteria
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public List<ChildCriteria>? child_criteria { get; set; }
        public Operator Operator { get; set; }
        public bool is_completed { get; set; }
    }

    public class CharacterCriteria
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public List<ChildCriteria> child_criteria { get; set; }
        public Operator Operator { get; set; }
        public bool is_completed { get; set; }
    }

    public class ChildCriteria
    {
        public int Id { get; set; }
        public string? description { get; set; }
        public string? amount { get; set; }
        public bool is_completed { get; set;  }
    }

    public class CharacterChildCriteria
    {
        public long Id { get; set; }
        public int CriteriaId { get; set; }
        public long CharacterId { get; set; }
        public string? description { get; set; }
        public string? amount { get; set; }
        public bool is_completed { get; set; }
    }

    public class Operator
    {
        public int Id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
    }
}
