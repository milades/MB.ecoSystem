using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MB.AuthDefinition.Entities.Identity
{
    public class Users : IdentityUser<int>
    {
        [StringLength(50)]
        public string? first_name { get; set; }

        [StringLength(50)]
        public string? last_name { get; set; }

        // [NotMapped]
        //public string? full_name =>$"{first_name} {last_name} ({UserName})";
        public string? full_name { get; set; }
        public string? father_name { get; set; }


        [StringLength(10)]
        public string? pers_code { get; set; }

        [StringLength(50)]
        public string? mobile { get; set; }

        [StringLength(50)]
        public string? tell { get; set; }

        public string? avatar { get; set; }

        [StringLength(50)]
        public string? national_code { get; set; }

        [StringLength(50)]
        public string? sys_code { get; set; }

        [StringLength(500)]
        public string? address { get; set; }
        public DateTime? birth_date { get; set; }

        //[ForeignKey("Parent")]
        //public int? parent_id { get; set; }
        //public virtual Users? Parent { get; set; }

        //public virtual ICollection<Users>? childs { get; set; }

        public bool is_deleted { get; set; } = false;
        public bool is_lock { get; set; } = false;

    }
}
