using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using StudentApp.Models.Mapping;
using StudentApp.Repository;

namespace StudentApp.Models
{
    public partial class StudentDBContext : DbContext, IDbContext
    {
        static StudentDBContext()
        {
            Database.SetInitializer<StudentDBContext>(null);
        }

        public StudentDBContext()
            : base("Name=StudentDBContext")
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMap());
        }
    }
}
