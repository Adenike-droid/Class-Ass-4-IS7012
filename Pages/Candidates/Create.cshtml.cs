using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCat_Username_.Data;
using RecruitCat_Username_.Models;

namespace RecruitCat_Username_.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCat_Username_.Data.RecruitCatContext _context;

        public CreateModel(RecruitCat_Username_.Data.RecruitCatContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Id");
        ViewData["IndustryId"] = new SelectList(_context.Industries, "Id", "Id");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitles, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidates.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
