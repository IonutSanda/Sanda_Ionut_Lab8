using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sanda_Ionut_Lab8.Models;

namespace Sanda_Ionut_Lab8.Data
{
    public class Sanda_Ionut_Lab8Context : DbContext
    {
        public Sanda_Ionut_Lab8Context (DbContextOptions<Sanda_Ionut_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sanda_Ionut_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sanda_Ionut_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sanda_Ionut_Lab8.Models.Category> Category { get; set; }
    }
}
