using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleMVC.Models;

namespace SampleMVC.Data
{
    public class SampleMVCContext : DbContext
    {
        public SampleMVCContext (DbContextOptions<SampleMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SampleMVC.Models.Author> Author { get; set; } = default!;

        public DbSet<SampleMVC.Models.Book> Book { get; set; }
    }
}
