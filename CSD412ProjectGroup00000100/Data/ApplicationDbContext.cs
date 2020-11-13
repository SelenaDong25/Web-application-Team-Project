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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /*
             these calls are to make the composite foreign key in net framework
             they do not cascade sql 
             
             */

            builder.Entity<Poll>()
            .HasOne(p => p.User)
            .WithMany(c => c.Polls)
            .OnDelete(DeleteBehavior.ClientNoAction)
            .HasForeignKey(p =>p.UserId) ;

            builder.Entity<Poll>().HasKey(p => new { p.UserId, p.PollId });
           
            builder.Entity<Item>()
            .HasOne(p => p.Poll)
            .WithMany(c => c.Items)
            .OnDelete(DeleteBehavior.ClientNoAction)
            .IsRequired()
            .HasForeignKey(p => new { p.UserId, p.PollId});

            builder.Entity<Item>().HasKey(p => new {p.ItemId, p.UserId, p.PollId });

            builder.Entity<Vote>()
            .HasOne(p => p.Item)
            .WithMany(c => c.Votes)
            .OnDelete(DeleteBehavior.ClientNoAction)
            .IsRequired()
            .HasForeignKey(p => new { p.ItemId, p.UserId, p.PollId });

            builder.Entity<Vote>()
            .HasOne(p => p.Voter)
            .WithMany(c => c.Votes)
            .OnDelete(DeleteBehavior.ClientNoAction)
            .IsRequired()
            .HasForeignKey(p =>  p.VoterId );

            builder.Entity<Vote>().HasKey(p => new { p.ItemId, p.UserId, p.PollId, p.VoterId });
        }
        public DbSet<Item> Items { get; set; }
       public DbSet<Poll> Polls {get; set; }
       public DbSet<Vote> Votes { get; set; }
    }
}
