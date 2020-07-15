using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityScaffold.Mvc.Models
{
    // Add profile data for application users by adding properties to the IdentityScaffoldUser class
    public class ApplicationUser : IdentityUser<int>
    {
        //[PersonalData]
        //public DateTime DOB { get; set; }
        public ApplicationUser()
        {
            Claims = new List<IdentityUserClaim<int>>();
            Logins = new List<IdentityUserLogin<int>>();
            Tokens = new List<IdentityUserToken<int>>();
            UserRoles = new List<IdentityUserRole<int>>();
        }
        public string RealName { get; set; }
        [PersonalData]
        public string Name { get; set; }

        [MaxLength(18)]
        public string IdCardNo { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public ICollection<IdentityUserClaim<int>> Claims { get; set; }
        public ICollection<IdentityUserLogin<int>> Logins { get; set; }
        public ICollection<IdentityUserToken<int>> Tokens { get; set; }
        public ICollection<IdentityUserRole<int>> UserRoles { get; set; }
    }
}
