namespace WoWCollectionTracker.Client.Models.AuthToken
{
    public class AuthToken
    {
        public int Id { get; set; }
        public string HashedToken { get; set; }
        public DateTime Acquired { get; set; }
        public DateTime Expires { get; set; }
    }
}
