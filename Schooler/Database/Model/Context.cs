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

		public virtual DbSet<attendance> attendance { get; set; }
		public virtual DbSet<_class> _class { get; set; }
		public virtual DbSet<lesson> lesson { get; set; }
		public virtual DbSet<QRKod> QRKod { get; set; }
		public virtual DbSet<schoolboy> schoolboy { get; set; }
		public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
		public virtual DbSet<users> users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<_class>()
				.Property(e => e.name_class)
				.IsUnicode(false);

			modelBuilder.Entity<_class>()
				.Property(e => e.classroom_teacher)
				.IsUnicode(false);

			modelBuilder.Entity<lesson>()
				.Property(e => e.name_predmet)
				.IsUnicode(false);

			modelBuilder.Entity<lesson>()
				.Property(e => e.teacher)
				.IsUnicode(false);

			modelBuilder.Entity<lesson>()
				.Property(e => e.day)
				.IsUnicode(false);

			modelBuilder.Entity<QRKod>()
				.Property(e => e.content)
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
				.Property(e => e.contacts)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<schoolboy>()
				.HasMany(e => e.attendance)
				.WithRequired(e => e.schoolboy)
				.HasForeignKey(e => e.guid_schoolboy);

			modelBuilder.Entity<schoolboy>()
				.HasMany(e => e.QRKod)
				.WithRequired(e => e.schoolboy)
				.HasForeignKey(e => e.id_schoolboy);

			modelBuilder.Entity<users>()
				.Property(e => e.login)
				.IsUnicode(false);

			modelBuilder.Entity<users>()
				.Property(e => e.password)
				.IsUnicode(false);

			modelBuilder.Entity<users>()
				.Property(e => e.role)
				.IsUnicode(false);

			modelBuilder.Entity<users>()
				.Property(e => e.last_name_user)
				.IsUnicode(false);

			modelBuilder.Entity<users>()
				.Property(e => e.name_user)
				.IsUnicode(false);

			modelBuilder.Entity<users>()
				.Property(e => e.patronymic_user)
				.IsUnicode(false);
		}
	}
}
