using HoneydewList.Components.Pages;
using Microsoft.EntityFrameworkCore;
using System;
using System.ServiceModel.Syndication;

namespace HoneydewList
{
    public class HoneydewListDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }

        public HoneydewListDbContext(DbContextOptions<HoneydewListDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItem>().HasKey(t => t.Id);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskItem>().HasData(
                new TaskItem 
                { 
                    Id = 1,
                    Title = "Feed Cat", 
                    Description = "Give cat 1/4 cup of food in the morning", 
                    Priority = TaskPriority.High, 
                    IsCompleted = false, Type = 
                    TaskType.Daily 
                });
            
        }
    }
}
