using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QLtailieu.Data;
using QLtailieu.Models;

namespace QLtailieu.Pages.Tailieus
{
    public class DetailsModel : PageModel
    {
        private readonly QLtailieu.Data.QLtailieuContext _context;

        public DetailsModel(QLtailieu.Data.QLtailieuContext context)
        {
            _context = context;
        }

      public Tailieu Tailieu { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tailieus == null)
            {
                return NotFound();
            }

            var tailieu = await _context.Tailieus.FirstOrDefaultAsync(m => m.ID == id);
            if (tailieu == null)
            {
                return NotFound();
            }
            else 
            {
                Tailieu = tailieu;
            }
            return Page();
        }
    }
}
