namespace SharedModels.Models
{
    public class LocalItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Patch { get; set; }
        public string SubCategory { get; set; }
        public bool Collected { get; set; }
        public bool Tracked { get; set; }
        public bool Show {  get; set; }
        public int DisplayOrder { get; set; }
    }
}
