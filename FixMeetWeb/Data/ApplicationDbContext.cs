using System;
using System.Collections.Generic;
using System.Text;
using FixMeetWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FixMeetWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<FixMeetWeb.Models.Booking> Booking { get; set; }
    }
}
