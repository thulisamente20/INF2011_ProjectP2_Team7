using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011_ProjectP2_Team7.Models
{
    public class Learner
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string School { get; set; }
        public string Province { get; set; }
        public string ContactDetails { get; set; }
        public List<LearnerSubject> Subjects { get; set; } = new List<LearnerSubject>();
        public List<LearnerInterestResponse> InterestResponses { get; set; } = new List<LearnerInterestResponse>();
    }
}

