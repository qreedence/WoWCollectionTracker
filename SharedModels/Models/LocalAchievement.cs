namespace SharedModels.Models
{
    public class LocalAchievement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public bool IsAccountWide { get; set; }
        public string CriteriaDescription { get; set; }
        public int CriteriaAmount { get; set; }
        public int? CriteriaId { get; set; }
        public Criteria? Criteria {  get; set; }
        public string Icon { get; set; }
        public string Patch { get; set; }
        public string SubCategory { get; set; }
        public string? SubSubCategory { get; set; }
        public bool Completed { get; set; }
        public bool Tracked { get; set; }
        public bool Show { get; set; }
        public bool Unobtainable { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? CompletionDateAndTime { get; set; }
    }
}
