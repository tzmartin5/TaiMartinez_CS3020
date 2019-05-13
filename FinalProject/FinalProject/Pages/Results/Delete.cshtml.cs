using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Results
{
    public class DeleteModel : PageModel
    {
        private readonly FinalProject.Models.FinalProjectContext _context;

        public DeleteModel(FinalProject.Models.FinalProjectContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Results = await _context.Results.FindAsync(id);

            if (Results != null)
            {
                _context.Results.Remove(Results);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
