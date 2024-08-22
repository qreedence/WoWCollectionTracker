namespace SharedModels.Models
{
    public class AuthToken
    {
        public int Id { get; set; }
        public string HashedToken { get; set; }
        public DateTime Acquired { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
