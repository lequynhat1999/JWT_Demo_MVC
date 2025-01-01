namespace JWT_Demo_MVC.Models
{
    public class JWTData
    {
        public string ValidIssuer { get; set; } = string.Empty;
        public string ValidAudience { get; set; } = string.Empty;
        public string SecretKey { get; set; } = string.Empty;
    }
}
