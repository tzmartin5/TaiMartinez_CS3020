using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace FinalProject.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.FinalProjectContext _context;

        public IndexModel(FinalProject.Models.FinalProjectContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Events { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedEvent { get; set; }


        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> query = from m in _context.Student
                                            orderby m.EventPref
                                            select m.EventPref;

            var students = from m in _context.Student
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                students = students.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(SelectedEvent))
            {
                students = students.Where(x => x.EventPref == SelectedEvent);
            }
            Events = new SelectList(await query.Distinct().ToListAsync());
            Student = await students.ToListAsync();

        }
    }
}
