namespace SharedModels.Models
{
    public class LocalMount
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string MountName { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Faction { get; set; }
        public string Patch { get; set; }
        public string SubCategory { get; set; }
        public string? SubSubCategory { get; set; }
        public bool Collected { get; set; }
        public bool Tracked { get; set; }
        public bool Show { get; set; }
        public int DisplayOrder { get; set; }
        public bool Unobtainable { get; set; }
    }
}
