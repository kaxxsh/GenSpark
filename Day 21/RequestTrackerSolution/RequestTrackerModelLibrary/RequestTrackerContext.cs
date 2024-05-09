﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace RequestTrackerModelLibrary
{
    public class RequestTrackerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<RequestTrackerContext>()
                .Build();
            var connectionString = builder.GetConnectionString("dbEmployeeTrackerCF");
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Request>? Requests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 101, Name = "Ramu", Password = "ramu123", Role = "Admin" },
                new Employee { Id = 102, Name = "Somu", Password = "somu123", Role = "Admin" },
                new Employee { Id = 103, Name = "Bimu", Password = "bimu123", Role = "User" },
                new Employee { Id = 104, Name = "User1", Password = "User1", Role = "User" }
                );

            modelBuilder.Entity<Request>().HasKey(r => r.RequestNumber);

            modelBuilder.Entity<Request>()
               .HasOne(r => r.RaisedByEmployee)
               .WithMany(e => e.RequestsRaised)
               .HasForeignKey(r => r.RequestRaisedBy)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();

            modelBuilder.Entity<Request>()
               .HasOne(r => r.RequestClosedByEmployee)
               .WithMany(e => e.RequestsClosed)
               .HasForeignKey(r => r.RequestClosedBy)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
