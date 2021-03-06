﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Models
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext (DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProject.Models.Student> Student { get; set; }
        public DbSet<FinalProject.Models.Schedule> Schedule { get; set; }
        public DbSet<FinalProject.Models.Result> Results { get; set; }
    }
}
