using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Test2.Models
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<CongNhan> CongNhans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CongNhan>()
                .Property(e => e.Macn)
                .IsFixedLength();

            modelBuilder.Entity<CongNhan>()
                .Property(e => e.Hoten)
                .IsFixedLength();

            modelBuilder.Entity<CongNhan>()
                .Property(e => e.Donvi)
                .IsFixedLength();

            modelBuilder.Entity<CongNhan>()
                .Property(e => e.Bacluong)
                .IsFixedLength();
        }
    }
}
