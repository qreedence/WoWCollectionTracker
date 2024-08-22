namespace SharedModels.Models
{
    public class MediaObject
    {
        public Links Links { get; set; }
        public List<Asset> Assets { get; set; }
        public int id { get; set; }
    }

    public class Asset
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public int FileDataId { get; set; }
    }

    public class Links
    {
        public Self Self { get; set; }
    }

    public class Self
    {
        public string Href { get; set; }
    }
    public class Key
    {
        public string Href { get; set; }
    }

    public class Media
    {
        public Key Key { get; set; }
        public int Id { get; set; }
    }
}
