using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MB.AuthDefinition
{   
    public class UserLogins : IdentityUserLogin<int>
    {
        public bool is_default { get; set; } = false;
        public bool is_deleted { get; set; } = false;
        public bool is_lock { get; set; } = false;
    }
}
