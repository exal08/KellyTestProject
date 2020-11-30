using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KellyTestProject.Model
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime DateTimeVisit { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
