using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DreamCreationDanceCrew.Models;

namespace DreamCreationDanceCrew.Data
{
    public class DreamCreationDanceCrewContext : DbContext
    {
        public DreamCreationDanceCrewContext (DbContextOptions<DreamCreationDanceCrewContext> options)
            : base(options)
        {
        }

        public DbSet<DreamCreationDanceCrew.Models.Event> Event { get; set; }
    }
}
