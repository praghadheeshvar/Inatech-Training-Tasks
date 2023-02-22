﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole.Model
{
    internal class ProdContext:DbContext
    {
        private const string connectionString = "Server=(Localdb)\\mssqllocaldb; Database=CoreProd; Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Product> Products { get; set;}
        public DbSet<ProductBatch> ProductBatchs { get; set;}
        public DbSet<Student> Students { get; set;}
        public DbSet<Standard> Standards { get; set;}
    }
}
