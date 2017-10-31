using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DAL.Models.Mapping;

namespace DAL.Models
{
    public partial class Std_RegContext : DbContext
    {
        static Std_RegContext()
        {
            Database.SetInitializer<Std_RegContext>(null);
        }

        public Std_RegContext()
            : base("Name=Std_RegContext")
        {
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PlaceMap());
            modelBuilder.Configurations.Add(new RegistrationMap());
        }
    }
}
