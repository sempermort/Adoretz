using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AdoreTz.Models;

namespace AdoreTz.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AdoreTz.Models.Category> Category { get; set; }
        public DbSet<AdoreTz.Models.News> News { get; set; }
        public DbSet<AdoreTz.Models.Job> Job { get; set; }
    }
}
