using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetSolutionWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetSolutionWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Career> Careers { get; set; }
    }
}
