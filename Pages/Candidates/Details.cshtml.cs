using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCat_Username_.Data;
using RecruitCat_Username_.Models;

namespace RecruitCat_Username_.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCat_Username_.Data.RecruitCatContext _context;

        public DetailsModel(RecruitCat_Username_.Data.RecruitCatContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidates.FirstOrDefaultAsync(m => m.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }
            else
            {
                Candidate = candidate;
            }
            return Page();
        }
    }
}
