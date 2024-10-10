using StudentPortal.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace StudentPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Gender> Gender { get; set; }

        public DbSet<TeacherCourse> TeacherCourse { get; set; } // Join table for Teacher and Course

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration for the TeacherCourse join table
            modelBuilder.Entity<TeacherCourse>()
                .HasKey(tc => new { tc.TeacherId, tc.CourseId });

            modelBuilder.Entity<TeacherCourse>()
                .HasOne(tc => tc.Teacher)
                .WithMany(t => t.TeacherCourses)
                .HasForeignKey(tc => tc.TeacherId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            modelBuilder.Entity<TeacherCourse>()
                .HasOne(tc => tc.Course)
                .WithMany(c => c.TeacherCourses)
                .HasForeignKey(tc => tc.CourseId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Student)
                .WithMany(s => s.Assignments)
                .HasForeignKey(a => a.StudentID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Subject)
                .WithOne(s => s.Assignment)
                .HasForeignKey<Assignment>(a => a.SubjectID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Teacher)
                .WithMany(t => t.Assignments)
                .HasForeignKey(a => a.TeacherID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            // Configure one-to-one relationship between Teacher and Subject
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Subject)
                .WithOne(s => s.Teacher)
                .HasForeignKey<Teacher>(t => t.SubjectId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading issues

            // Course -> Subject relationship
            modelBuilder.Entity<Subject>()
                .HasOne(s => s.Course)
                .WithMany(c => c.Subjects)
                .HasForeignKey(s => s.CourseID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading issues

            // Subject -> Lesson relationship
            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Subject)
                .WithMany(s => s.Lessons)
                .HasForeignKey(l => l.SubjectID)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading issues

            // Note: You can also explicitly set the Course relationship in Lesson if needed
        }


    }
}
