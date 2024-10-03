using System.Collections.Generic;

using System.Collections.Generic;

namespace RecruitCat_Username_.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string JobDescription { get; set; }
        public bool IsFullTime { get; set; }

        // Navigation Property
        public List<Candidate> Candidates { get; set; }
    }
}

