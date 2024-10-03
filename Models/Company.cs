using System;
using System.Collections.Generic;

namespace RecruitCat_Username_.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime? StartDate { get; set; }  // Nullable
        public string Location { get; set; }

        // Additional properties
        public string WebsiteUrl { get; set; }  // Optional
        public bool IsHiringRemotely { get; set; }

        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
