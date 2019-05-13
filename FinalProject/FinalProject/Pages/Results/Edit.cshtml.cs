using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Results
{
    public class EditModel : PageModel
    {
        private readonly FinalProject.Models.FinalProjectContext _context;

        public EditModel(FinalProject.Models.FinalProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Result Results { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Results = await _context.Results.FirstOrDefaultAsync(m => m.ID == id);

            if (Results == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Results).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultsExists(Results.ID))
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

        private bool ResultsExists(int id)
        {
            return _context.Results.Any(e => e.ID == id);
        }
    }
}
