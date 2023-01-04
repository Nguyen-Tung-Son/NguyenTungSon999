using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenTungSon999.Models;

namespace NguyenTungSon999.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenTungSon999.Models.UniversityNTS999> UniversityNTS999 { get; set; } = default!;
    }
}
