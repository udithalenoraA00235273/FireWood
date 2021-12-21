using FireWood.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FireWood.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public void ListAsync()
        {
            throw new NotImplementedException();
        }

        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<UserApplication> UserApplications { get; set; }

    }
}
