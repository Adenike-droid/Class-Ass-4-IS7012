using System;
using System.ComponentModel.DataAnnotations;

namespace RecruitCat_Username_.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]  // Required validation
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]  // Required validation
        public string LastName { get; set; }

        [Display(Name = "Target Salary")]
        [Range(0, 1000000, ErrorMessage = "Target salary must be between 0 and 1,000,000")]
        public decimal TargetSalary { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }  // Nullable StartDate

        [Display(Name = "Job Title")]
        public int JobTitleId { get; set; }

        public JobTitle JobTitle { get; set; }  // Not nullable, assuming it's always required

        [Display(Name = "Company")]
        public int? CompanyId { get; set; }  // Nullable, if company is optional

        public Company Company { get; set; }

        [Display(Name = "Industry")]
        public int IndustryId { get; set; }  // Assuming Industry is mandatory
        public Industry Industry { get; set; }

        // Optional properties
        [Display(Name = "Resume Link")]
        public string? ResumeLink { get; set; }  // Optional string

        [Display(Name = "Actively Looking")]
        public bool IsActivelyLooking { get; set; }
    }
}
