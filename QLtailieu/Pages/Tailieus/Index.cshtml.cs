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
    public class IndexModel : PageModel
    {
        private readonly QLtailieu.Data.QLtailieuContext _context;

        public IndexModel(QLtailieu.Data.QLtailieuContext context)
        {
            _context = context;
        }

        public IList<Tailieu> Tailieu { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Tailieus != null)
            {
                Tailieu = await _context.Tailieus.ToListAsync();
            }
        }
    }
}
