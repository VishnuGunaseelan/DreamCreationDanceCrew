using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DreamCreationDanceCrew.Data;
using DreamCreationDanceCrew.Models;

namespace DreamCreationDanceCrew.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext _context;

        public DetailsModel(DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
