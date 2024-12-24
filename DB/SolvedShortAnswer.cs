using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.DB
{
    public class SolvedShortAnswer
    {
        public long ID { get; set; }
        public DateTime SolvedDate { get; set; }
        public string ModuleTitle { get; set; }

        public decimal? Grade { get; set; }
    }
}
