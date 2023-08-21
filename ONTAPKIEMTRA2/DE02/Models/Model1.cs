using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DE02.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<SanPham> SanPham { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>()
                .Property(e => e.Masp)
                .IsFixedLength();
        }
    }
}
