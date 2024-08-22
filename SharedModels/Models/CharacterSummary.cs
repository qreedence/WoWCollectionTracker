namespace SharedModels.Models
{
    public class CharacterSummary
    {
        public Links? _links { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Faction Faction { get; set; }
        public Race Race { get; set; }
        public CharacterClass character_class { get; set; }
        public ActiveSpec? active_spec { get; set; }
        public Realm Realm { get; set; }
        public Guild? Guild { get; set; }
        public int Level { get; set; }
        public int achievement_points { get; set; }
        public Achievements Achievements { get; set; }
        public Titles? Titles { get; set; }
        public PvPSummary? pvp_summary { get; set; }
        public Encounters? Encounters { get; set; }
        public CharacterMedia? Media { get; set; }
        public long last_login_timestamp { get; set; } 
        public int average_item_level { get; set; }
        public int equipped_item_level { get; set; }
        public Specializations? Specializations { get; set; }
        public Statistics? Statistics { get; set; }
        public MythicKeystoneProfile? mythic_keystone_profile { get; set; }
        public Equipment? Equipment { get; set; }
        public Appearance? Appearance { get; set; }
        public Collections? Collections { get; set; }
        public ActiveTitle? active_title { get; set; }
        public Reputations? Reputations { get; set; }
        public Quests? Quests { get; set; }
        public AchievementsStatistics? achievements_statistics { get; set; }
        public Professions? Professions { get; set; }
        public CovenantProgress? covenant_progress { get; set; }
        public string? name_search { get; set; }

        public MediaObject MediaObject { get; set; }
        public CollectionsUrls CollectionsUrls { get; set; }
        public List<AchievementEntry> AchievementList { get; set; }
        public List<int> MountList { get; set; }
        public List<int> PetList { get; set; }
        public List<int> ToyList { get; set; }
        public List<int> TransmogList { get; set; }
    }

    public class Gender
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }

    public class CharacterMedia
    {
        public string Href { get; set; }
    }

    public class Race
    {
        public Key Key { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class CharacterClass
    {
        public Key Key { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class ActiveSpec
    {
        public Key? Key { get; set; }
        public string? Name { get; set; }
        public int Id { get; set; }
    }

    public class Realm
    {
        public Key Key { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Slug { get; set; }
    }

    public class Guild
    {
        public Key? Key { get; set; }
        public string? Name { get; set; }
        public int? Id { get; set; }
        public Realm? Realm { get; set; }
        public Faction? Faction { get; set; }
    }

    public class Achievements
    {
        public string? Href { get; set; }
    }

    public class Titles
    {
        public string? Href { get; set; }
    }

    public class PvPSummary
    {
        public string? Href { get; set; }
    }

    public class Encounters
    {
        public string? Href { get; set; }
    }

    public class Specializations
    {
        public string? Href { get; set; }
    }

    public class Statistics
    {
        public string? Href { get; set; }
    }

    public class MythicKeystoneProfile
    {
        public string? Href { get; set; }
    }

    public class Equipment
    {
        public string? Href { get; set; }
    }

    public class Appearance
    {
        public string? Href { get; set; }
    }

    public class Collections
    {
        public string? Href { get; set; }
    }

    public class ActiveTitle
    {
        public Key? Key { get; set; }
        public string? Name { get; set; }
        public int Id { get; set; }
        public string? display_string { get; set; }
    }

    public class Reputations
    {
        public string? Href { get; set; }
    }

    public class Quests
    {
        public string? Href { get; set; }
    }

    public class AchievementsStatistics
    {
        public string? Href { get; set; }
    }

    public class Professions
    {
        public string? Href { get; set; }
    }

    public class CovenantProgress
    {
        public ChosenCovenant chosen_covenant { get; set; }
        public int renown_level { get; set; }
        public Soulbinds Soulbinds { get; set; }
    }

    public class ChosenCovenant
    {
        public Key? Key { get; set; }
        public string? Name { get; set; }
        public int Id { get; set; }
    }

    public class Soulbinds
    {
        public string? Href { get; set; }
    }
}
