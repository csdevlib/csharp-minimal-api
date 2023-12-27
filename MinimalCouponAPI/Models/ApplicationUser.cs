using Microsoft.AspNetCore.Identity;

namespace MinimalCouponAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
