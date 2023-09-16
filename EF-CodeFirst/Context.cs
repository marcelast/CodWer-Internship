using EF_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    class Context : DbContext
    {
        public Context()
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Specialitate> Specialitati { get; set; }
        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Curs> Cursuri { get; set; }
        public DbSet<Facultate> Facultati { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-EQAGHQS;Database=UTM-db;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Specialitate)
                .WithMany(sp => sp.Students)
                .HasForeignKey(s => s.SpecialitateId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Facultate)
                .WithMany(f => f.Students)
                .HasForeignKey(s => s.FacultateId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Specialitate>()
                .HasOne(sp => sp.Facultate)
                .WithMany(f => f.Specialitati)
                .HasForeignKey(sp => sp.FacultateId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
