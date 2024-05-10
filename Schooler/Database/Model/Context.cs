using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Schooler.Database.Model
{
    public partial class Context : DbContext
    {
        public Context()
            : base(StateSingleton.getInstance().connectionString)
        {
        }

        public virtual DbSet<attendance> attendances { get; set; }
        public virtual DbSet<authorization> authorizations { get; set; }
        public virtual DbSet<_class> classes { get; set; }
        public virtual DbSet<schoolboy> schoolboys { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<authorization>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<authorization>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.name_class)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.classroom_teacher)
                .IsUnicode(false);

            modelBuilder.Entity<schoolboy>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<schoolboy>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<schoolboy>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<schoolboy>()
                .Property(e => e.surname_NP_parents)
                .IsUnicode(false);

            modelBuilder.Entity<schoolboy>()
                .Property(e => e.parents_email)
                .IsUnicode(false);

            modelBuilder.Entity<schoolboy>()
                .Property(e => e.QR_kod)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.authorizations)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
