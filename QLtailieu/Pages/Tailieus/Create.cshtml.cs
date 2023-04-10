using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QLtailieu.Data;
using QLtailieu.Models;

namespace QLtailieu.Pages.Tailieus
{
    public class CreateModel : PageModel
    {
        private readonly QLtailieu.Data.QLtailieuContext _context;

        public CreateModel(QLtailieu.Data.QLtailieuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tailieu Tailieu { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Tailieus == null || Tailieu == null)
            {
                return Page();
            }

            _context.Tailieus.Add(Tailieu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
