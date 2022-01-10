using DreamCreationDanceCrew.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DreamCreationDanceCrew.Controllers
{

    public class HomeController : Controller
    {
        private readonly DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext _context;

        public HomeController(DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var model = await _context.Event.ToListAsync();
            return View(model);
        }

    }
} 