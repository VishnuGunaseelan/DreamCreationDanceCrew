using DreamCreationDanceCrew.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DreamCreationDanceCrew.Controllers
{

    public class HomeController : Controller
    {
        private readonly DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext _context;
        public HomeController(DreamCreationDanceCrew.Data.DreamCreationDanceCrewContext context)
        {
            _context = context;
        }

        public IActionResult DreamCreation()
        {
        Event model = new Event();
        model.CheckboxGroups = new List<EnumModel>();
        foreach (Groups groups in Enum.GetValues(typeof(Groups)))
            {
                model.CheckboxGroups.Add(new EnumModel() { Group = groups, IsSelected = false });
            }
        return View(model);
        }

    }
} 