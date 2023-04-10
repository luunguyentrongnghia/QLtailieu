using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLtailieu.Data;
using QLtailieu.Models;

namespace QLtailieu.Pages.Tailieus
{
    public class EditModel : PageModel
    {
        private readonly QLtailieu.Data.QLtailieuContext _context;

        public EditModel(QLtailieu.Data.QLtailieuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tailieu Tailieu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tailieus == null)
            {
                return NotFound();
            }

            var tailieu =  await _context.Tailieus.FirstOrDefaultAsync(m => m.ID == id);
            if (tailieu == null)
            {
                return NotFound();
            }
            Tailieu = tailieu;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Tailieu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TailieuExists(Tailieu.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TailieuExists(int id)
        {
          return (_context.Tailieus?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
