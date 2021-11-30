using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DreamCreationDanceCrew.Data;
using DreamCreationDanceCrew.Models;

namespace DreamCreationDanceCrew.Pages.Events
{
    public class CreateModel : PageModel
    {
        private readonly DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext _context;

        public CreateModel(DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Event Event { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Event.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
