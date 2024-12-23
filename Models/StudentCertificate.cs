using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.Models
{
    public class StudentCertificate
    {
        public long Id { get; set; }
        public long Grade { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string studentName { get; set; }
        public string certificateName { get; set; }
    }
}
