using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapplication.DAL.entity1;

namespace webapplication.DAL.database
{

    public class mydbcontext : DbContext
    {
        public DbSet<student> student { get; set; }
        public DbSet<course> course { get; set; }
        public DbSet<session> session { get; set; }
        public DbSet<tasks> tasks { get; set; }
        public DbSet<admin> admin { get; set; }
        public DbSet<parent> parent { get; set; }
        public DbSet<Communications> Communications { get; set; }
        public DbSet<lectuerstudent> lectuerstuden { get; set; }
        public DbSet<lecture> lecture { get; set; }
        public DbSet<student_cource> student_cource { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog =Kidsschool;Encrypt=False; Integrated Security = True");
            // base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student_cource>().HasKey(x => new { x.idstudent, x.idcourse });
            modelBuilder.Entity<lectuerstudent>().HasKey(x => new { x.idstudent, x.idlectuer });
            modelBuilder.Entity<course>().HasOne<lecture>(e => e.lecture).WithMany(d => d.course);
            modelBuilder.Entity<session>().HasOne<course>(e => e.course).WithMany(d => d.session);
            modelBuilder.Entity<session>().HasOne<lecture>(e => e.lecture).WithMany(d => d.session);
            modelBuilder.Entity<student>().HasOne<parent>(e => e.parent).WithMany(d => d.student);
            modelBuilder.Entity<Communications>().HasOne<student>(e => e.student).WithMany(d => d.Communications);
            modelBuilder.Entity<Communications>().HasOne<lecture>(e => e.lecture).WithMany(d => d.Communications);
            modelBuilder.Entity<tasks>().HasOne<student>(e => e.student).WithMany(d => d.tasks);
            modelBuilder.Entity<tasks>().HasOne<lecture>(e => e.lecture).WithMany(d => d.tasks);
            base.OnModelCreating(modelBuilder);
        }
    }
}
