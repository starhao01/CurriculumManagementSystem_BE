using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                               .AddJsonFile("appsettings.json", true, true)
                                               .Build();
            string? con = connectionString.GetConnectionString("CMSDb");
            optionsBuilder.UseSqlServer(con);
        }

        public virtual DbSet<AssessmentMethod> AssessmentMethods { get; set; }
        public virtual DbSet<AssessmentType> AssessmentTypes { get; set; }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<ClassSessionType> ClassSessionTypes { get; set; }
        public virtual DbSet<CLO> CLOs { get; set; }
        public virtual DbSet<Combo> Combos { get; set; }
        public virtual DbSet<ComboSubject> ComboSubjects { get; set; }
        public virtual DbSet<Curriculum> Curriculums { get; set; }
        public virtual DbSet<CurriculumSubject> CurriculumSubjects { get; set; }
        public virtual DbSet<GradingCLO> GradingCLOs { get; set; }
        public virtual DbSet<GradingStruture> GradingStrutures { get; set; }
        public virtual DbSet<LearningMethod> LearningMethods { get; set; }
        public virtual DbSet<LearningResource> LearningResources { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<PLOMapping> PLOMappings { get; set; }
        public virtual DbSet<PLOs> PLOs { get; set; }
        public virtual DbSet<PreRequisite> PreRequisites { get; set; }
        public virtual DbSet<PreRequisiteType> PreRequisiteTypes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Quiz> Quizzes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<SemesterPlan> SemesterPlans { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<SpecializationSubject> SpecializationSubjects { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Syllabus> Syllabus { get; set; }
        public virtual DbSet<TimeAllocation> TimeAllocations { get; set; }
        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //create primary key
            modelBuilder.Entity<ComboSubject>()
               .HasKey(ba => new { ba.combo_id, ba.subject_id });

            modelBuilder.Entity<CurriculumSubject>()
               .HasKey(ba => new { ba.curriculum_id, ba.subject_id });

            modelBuilder.Entity<GradingCLO>()
               .HasKey(ba => new { ba.grading_id, ba.CLO_id });

            modelBuilder.Entity<PLOMapping>()
               .HasKey(ba => new { ba.PLO_id, ba.subject_id });

            modelBuilder.Entity<SemesterPlan>()
               .HasKey(ba => new { ba.semester_id, ba.curriculum_id });

            modelBuilder.Entity<SpecializationSubject>()
               .HasKey(ba => new { ba.specialization_id, ba.subject_id });

            modelBuilder.Entity<TimeAllocation>()
               .HasKey(ba => new { ba.CLO_id, ba.session_id });

            //create new Data in table
            modelBuilder.Entity<Role>().HasData(
                new Role { role_id = 1, role_name = "Dispatcher" },
                new Role { role_id = 2, role_name = "Manager" },
                new Role { role_id = 3, role_name = "Admin" }
                );
            modelBuilder.Entity<User>().HasData(
                new User { user_id = 1, full_name = "Chu Quang Quan", role_id = 1, user_address = "Ha Nam", user_email = "chuquan2k1@gmail.com", user_name = "QuanCQ", user_phone = 0349457905, user_status = "Active" }
                );
        }
    }
}
