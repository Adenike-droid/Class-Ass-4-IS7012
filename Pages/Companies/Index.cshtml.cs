using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCat_Username_.Data;
using RecruitCat_Username_.Models;

namespace RecruitCat_Username_.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCat_Username_.Data.RecruitCatContext _context;

        public IndexModel(RecruitCat_Username_.Data.RecruitCatContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Company = await _context.Companies
                .Include(c => c.Industry).ToListAsync();
        }
    }
}
