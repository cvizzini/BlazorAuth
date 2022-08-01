using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Server.Context.Entities
{
    public class User : IdentityUser
    {
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
