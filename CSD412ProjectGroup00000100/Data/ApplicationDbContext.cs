using System;
using System.Collections.Generic;
using System.Text;
using CSD412ProjectGroup00000100.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CSD412ProjectGroup00000100.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       public DbSet<Item> Items { get; set; }
       public DbSet<Poll> Polls {get; set; }
       public DbSet<Vote> Votes { get; set; }
    }
}
