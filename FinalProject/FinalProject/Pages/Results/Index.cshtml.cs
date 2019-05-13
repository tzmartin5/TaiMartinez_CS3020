using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace FinalProject.Pages.Results
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.FinalProjectContext _context;

        public IndexModel(FinalProject.Models.FinalProjectContext context)
        {
            _context = context;
        }

        public IList<Result> Results { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Events { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SpecificEvent { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> query = from m in _context.Results
                                            orderby m.Event
                                            select m.Event;

            var r = from m in _context.Results
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                r = r.Where(s => s.MeetName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(SpecificEvent))
            {
                r = r.Where(x => x.Event == SpecificEvent);
            }
            Events = new SelectList(await query.Distinct().ToListAsync());
            Results = await r.ToListAsync();

        }


    }
    }

