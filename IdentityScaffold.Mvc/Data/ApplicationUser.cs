using Microsoft.AspNetCore.Identity;

namespace IdentityScaffold.Mvc.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the IdentityScaffoldUser class
    public class ApplicationUser : IdentityUser<int>
    {
        public string  RealName { get; set; }
    }
}
