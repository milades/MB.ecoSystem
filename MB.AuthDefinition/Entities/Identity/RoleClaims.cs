using MB.DefaultConstants.Shared;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MB.AuthDefinition
{   
    public class RoleClaims : IdentityRoleClaim<int>
    {
        public bool is_default { get; set; } = false;
        public bool is_deleted { get; set; } = false;
        public bool is_lock { get; set; } = false;
    }
}
