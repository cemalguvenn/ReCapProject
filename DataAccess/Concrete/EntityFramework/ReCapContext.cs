﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCap;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        //public DbSet<Brand> Brands { get; set; }
        //public DbSet<Color> Colors { get; set; }
    }
}
