using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011_ProjectP2_Team7.Models
{
    public class LearnerSubject
    {
        public string SubjectName { get; set; }
        public int Mark { get; set; }
        public string Status { get; set; }

        // Part 1 class diagram lists "status" for this class, but its meaning is not
        // defined and the LearnerSubject table has no status column. Not saved to the
        // database; to be confirmed with the business logic owner (Member C)
    }
}
