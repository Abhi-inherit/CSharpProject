using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DAL.Models.Mapping;

namespace DAL.Models
{
    public partial class FirstMCV_PartialViewContext : DbContext
    {
        static FirstMCV_PartialViewContext()
        {
            Database.SetInitializer<FirstMCV_PartialViewContext>(null);
        }

        public FirstMCV_PartialViewContext()
            : base("Name=FirstMCV_PartialViewContext")
        {
        }

        public DbSet<tbl_People> tbl_People { get; set; }
        public DbSet<tbl_Place> tbl_Place { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new tbl_PeopleMap());
            modelBuilder.Configurations.Add(new tbl_PlaceMap());
        }
    }
}
