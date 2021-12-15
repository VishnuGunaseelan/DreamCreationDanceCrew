﻿using DreamCreationDanceCrew.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DreamCreationDanceCrew.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
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