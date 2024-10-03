using System.Collections.Generic;

namespace RecruitCat_Username_.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Additional properties
        public string Sector { get; set; }  // Optional

        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Company> Companies { get; set; }
    }
}
