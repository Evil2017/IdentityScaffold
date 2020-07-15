using IdentityScaffold.Mvc.Models;
using System.Collections.Generic;

namespace IdentityScaffold.Mvc.ViewModels
{
    public class UserRoleViewModel
    {
        public UserRoleViewModel()
        {
            Users = new List<ApplicationUser>();
        }

        public int UserId { get; set; }
        public int RoleId { get; set; }

        public List<ApplicationUser> Users { get; set; }
    }
}
