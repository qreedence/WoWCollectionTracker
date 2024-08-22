namespace SharedModels.Models
{
    public class Mount
    {
        public Links _links { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CreatureDisplay> CreatureDisplays { get; set; }
        public string Description { get; set; }
        public Source Source { get; set; }
        public Faction Faction { get; set; }
        public Requirements Requirements { get; set; }
    }

    public class CreatureDisplay
    {
        public Key Key { get; set; }
        public int Id { get; set; }
    }

    public class Source
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }

    public class Faction
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }

    public class Requirements
    {
        public Faction Faction { get; set; }
    }
}
