namespace JwtDemo.Models
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public string Token { get; set; } = null!;
        public DateTime ExpiresAttUtc { get; set; }
        public DateTime CreatedAtutc { get; set; }
        public bool userId { get; set; }
        public User User { get; set; } = null!;
    }
}
