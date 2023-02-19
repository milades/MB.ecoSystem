using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.PublicLibraries.Email.Models
{
    
    public class MailRequestDetails
    {
        public string ToEmail { get; set; }
        public string? FullName { get; set; }
        public string UserName { get; set; }
        public string? Url { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }
}
