using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MB.AuthDefinition
{
    public class Roles : IdentityRole<int>
    {
        public string? caption { get; set; }        

        [ForeignKey("Parent")]
        public int? parent_id { get; set; }
        public virtual Roles? Parent { get; set; }

        public virtual ICollection<Roles>? childs { get; set; }

        public bool is_default { get; set; } = false;
        public bool is_deleted { get; set; } = false;
        public bool is_lock { get; set; } = false;

    }
}
