using Microsoft.AspNetCore.Identity;
using System;

namespace IdentityScaffold.Mvc.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the IdentityScaffoldUser class
    public class ApplicationUser : IdentityUser<int>
    {
        public string  RealName { get; set; }
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
