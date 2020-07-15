using System.ComponentModel.DataAnnotations;

namespace IdentityScaffold.Mvc.ViewModels
{
    public class RoleAddViewModel
    {
        [Required]
        [Display(Name = "角色名称")]
        public string RoleName { get; set; }
    }
}
