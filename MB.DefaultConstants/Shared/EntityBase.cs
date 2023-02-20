using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MB.DefaultConstants.Shared
{
    public class EntityBase
    {
        [Key]
        public int id { get; set; }
        public DateTime? add_date { get; set; } = DateTime.Now;
        public DateTime? last_changed_date { get; set; }   
        public bool is_deleted { get; set; }
        public bool is_lock { get; set; }
    }
}
