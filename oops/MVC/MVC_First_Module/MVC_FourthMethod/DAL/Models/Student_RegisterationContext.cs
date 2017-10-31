using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DAL.Models.Mapping;

namespace DAL.Models
{
    public partial class Student_RegisterationContext : DbContext
    {
        static Student_RegisterationContext()
        {
            Database.SetInitializer<Student_RegisterationContext>(null);
        }

        public Student_RegisterationContext()
            : base("Name=Student_RegisterationContext")
        {
        }

        public DbSet<District> Districts { get; set; }
        public DbSet<StudentDetail> StudentDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DistrictMap());
            modelBuilder.Configurations.Add(new StudentDetailMap());
        }
    }
}
