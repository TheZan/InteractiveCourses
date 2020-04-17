namespace Courses.DBModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CoursesContext : DbContext
    {
        public CoursesContext()
            : base("name=CoursesContext")
        {
            Database.Connection.ConnectionString = @"data source=YOUR_SERVER_NAME;initial catalog=Courses;
            persist security info=True;user id=YOUR_LOGIN;password=YOUR_PASSWORD;MultipleActiveResultSets=True;App=EntityFramework";
        }

        public virtual DbSet<answer> answer { get; set; }
        public virtual DbSet<badge> badge { get; set; }
        public virtual DbSet<correctAnswer> correctAnswer { get; set; }
        public virtual DbSet<module> module { get; set; }
        public virtual DbSet<question> question { get; set; }
        public virtual DbSet<result> result { get; set; }
        public virtual DbSet<submodule> submodule { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<answer>()
                .HasMany(e => e.correctAnswer)
                .WithRequired(e => e.answer1)
                .HasForeignKey(e => e.answer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<module>()
                .HasMany(e => e.badge)
                .WithOptional(e => e.module)
                .WillCascadeOnDelete();

            modelBuilder.Entity<module>()
                .HasMany(e => e.submodule)
                .WithOptional(e => e.module)
                .WillCascadeOnDelete();

            modelBuilder.Entity<module>()
                .HasMany(e => e.test)
                .WithOptional(e => e.module)
                .WillCascadeOnDelete();

            modelBuilder.Entity<question>()
                .HasMany(e => e.correctAnswer)
                .WithRequired(e => e.question1)
                .HasForeignKey(e => e.question);
        }
    }
}
