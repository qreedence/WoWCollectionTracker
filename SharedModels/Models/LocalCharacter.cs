namespace SharedModels.Models
{
    public class LocalCharacter
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Faction { get; set; }
        public string Race { get; set; }
        public string CharacterClass { get; set; }
        public string? ActiveSpec { get; set; }
        public string Region { get; set; }
        public string Realm { get; set; }
        public string RealmSlug { get; set; }
        public string? Title { get; set; }
        public string? Guild { get; set; }
        public int Level { get; set; }
        public int AchievementPoints { get; set; }
        public List<int>? Mounts {get; set;}
        public List<int>? Pets {get; set;}
        public List<int>? Toys {get; set;}
        public List<int>? Transmog { get; set;}
        public DateTime LastLoggedIn { get; set; }
        public int AverageItemLevel { get; set; }
        public int EquippedItemLevel { get; set; }
        public string? Appearance { get; set; }
        public string? Collections { get; set; }
        public string? Reputations { get; set; }
        public string? Icon { get; set; }
        public string? BigImage { get; set; }
        public string? FullBodyImage { get; set; }
        public DateTime LastUpdated { get; set; }
    }

    public class AchievementEntry
    {
        public int Id { get; set; }
        public int AchievementId { get; set; }
        public long CompletedTimeStamp { get; set; }
        public bool IsCompleted { get; set; }
        public List<CharacterChildCriteria> criteria { get; set; } = new List<CharacterChildCriteria>();
    }
}
