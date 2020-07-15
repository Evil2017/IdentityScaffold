using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityScaffold.Mvc.ViewModels
{
    public class ManageClaimsViewModel
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public string ClaimId { get; set; }

        public List<string> AvailableClaims { get; set; }
    }
}
