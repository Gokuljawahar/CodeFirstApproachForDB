using LMS;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CodeFirstApproachForDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //Quiz
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<UserAttempt> UserAttempts { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<FeedbackQuestion> FeedbackQuestions { get; set; }
        public DbSet<FeedbackResponse> FeedbackResponses { get; set; }

        //User
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<PasswordHistory> PasswordHistories { get; set; }


        //Courses
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseCatagory> CourseCategory { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet<UserProgress> UserProgress { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Topic> Topic { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    //Quiz
        //    modelBuilder.Entity<QuizQuestion>()
        //        .HasOne(qq => qq.Quiz)
        //        .WithMany(q => q.QuizQuestions)
        //        .HasForeignKey(qq => qq.QuizId);

        //    modelBuilder.Entity<QuestionOption>()
        //        .HasOne(qo => qo.QuizQuestion)
        //        .WithMany(qq => qq.QuestionOptions)
        //        .HasForeignKey(qo => qo.QuizQuestionId);

        //    modelBuilder.Entity<UserAttempt>()
        //        .HasOne(ua => ua.Quiz)
        //        .WithMany(q => q.UserAttempts)
        //        .HasForeignKey(ua => ua.QuizId);

        //    modelBuilder.Entity<UserAnswer>()
        //        .HasOne(ua => ua.UserAttempt)
        //        .WithMany(ua => ua.UserAnswers)
        //        .HasForeignKey(ua => ua.UserAttemptId);

        //    modelBuilder.Entity<UserAnswer>()
        //        .HasOne(ua => ua.QuizQuestion)
        //        .WithMany(qq => qq.UserAnswers)
        //        .HasForeignKey(ua => ua.QuizQuestionId);

        //    modelBuilder.Entity<UserAnswer>()
        //        .HasOne(ua => ua.QuestionOption)
        //        .WithMany(qo => qo.UserAnswers)
        //        .HasForeignKey(ua => ua.QuestionOptionId);

        //    modelBuilder.Entity<FeedbackResponse>()
        //        .HasOne(fr => fr.FeedbackQuestion)
        //        .WithMany(fq => fq.FeedbackResponses)
        //        .HasForeignKey(fr => fr.FeedbackQuestionId);

        //    //User

        //    modelBuilder.Entity<Profile>()
        //       .HasOne(p => p.User)
        //       .WithOne(u => u.Profile)
        //       .HasForeignKey<Profile>(p => p.UserID);

        //    modelBuilder.Entity<Enrollment>()
        //        .HasOne(e => e.User)
        //        .WithOne(u => u.Enrollment)
        //        .HasForeignKey<Enrollment>(e => e.UserID);

        //    modelBuilder.Entity<PasswordHistory>()
        //        .HasOne(ph => ph.User)
        //        .WithOne(u => u.PasswordHistory)
        //        .HasForeignKey<PasswordHistory>(ph => ph.UserID);

           
        //}
    }
}
