using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011_ProjectP2_Team7.Models
{
    public class LearnerInterestResponse
    {
        public int QuestionID { get; set; }
        public int ResponseValue { get; set; } // 1 = Disagree, 2 = Neutral, 3 = Agree
    }
}
