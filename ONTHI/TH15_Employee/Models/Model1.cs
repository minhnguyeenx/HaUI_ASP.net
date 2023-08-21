using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TH15_Employee.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=CompanyContext")
        {
        }

        public virtual DbSet<Accout> Accout { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accout>()
                .Property(e => e.username)
                .IsUnicode(false);
        }
    }
}
