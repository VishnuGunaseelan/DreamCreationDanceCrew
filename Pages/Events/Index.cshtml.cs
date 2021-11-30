using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DreamCreationDanceCrew.Data;
using DreamCreationDanceCrew.Models;

namespace DreamCreationDanceCrew.Pages.Events
{
    public class IndexModel : PageModel
    {
        private readonly DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext _context;

        public IndexModel(DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Groups { get; set; }
        [BindProperty(SupportsGet = true)]
        public string EventGroup { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> groupQuery = from m in _context.Event
                                            orderby m.Group
                                            select m.Group;

            var events = from m in _context.Event
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                events = events.Where(s => s.Type.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(EventGroup))
            {
                events = events.Where(x => x.Group == EventGroup);
            }
            Groups = new SelectList(await groupQuery.Distinct().ToListAsync());
            Event = await events.ToListAsync();
        }
    }
}
