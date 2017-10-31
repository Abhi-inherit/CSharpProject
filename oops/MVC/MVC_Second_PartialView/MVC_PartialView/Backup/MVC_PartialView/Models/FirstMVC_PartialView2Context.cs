using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MVC_PartialView.Models.Mapping;

namespace MVC_PartialView.Models
{
    public partial class FirstMVC_PartialView2Context : DbContext
    {
        static FirstMVC_PartialView2Context()
        {
            Database.SetInitializer<FirstMVC_PartialView2Context>(null);
        }

        public FirstMVC_PartialView2Context()
            : base("Name=FirstMVC_PartialView2Context")
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
