using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenTungSon999;

    public class NguyenTungSon999Context : DbContext
    {
        public NguyenTungSon999Context (DbContextOptions<NguyenTungSon999Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenTungSon999.CompanyNTS999> CompanyNTS999 { get; set; }

        public DbSet<NguyenTungSon999.NTS0999> NTS0999 { get; set; }
    }
