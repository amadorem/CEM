using CEM.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEM.Data
{
    public class CEMContext : DbContext
    {
        public CEMContext(DbContextOptions<CEMContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();
        }

        public DbSet<SY> SYs { get; set; }
    }
}
