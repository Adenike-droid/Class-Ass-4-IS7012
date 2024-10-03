using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCat_Username_.Data;
using RecruitCat_Username_.Models;

namespace RecruitCat_Username_.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCat_Username_.Data.RecruitCatContext _context;

        public IndexModel(RecruitCat_Username_.Data.RecruitCatContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Industry = await _context.Industries.ToListAsync();
        }
    }
}
