using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MVC_PartialView.Models.Mapping
{
    public class tbl_PlaceMap : EntityTypeConfiguration<tbl_Place>
    {
        public tbl_PlaceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PlaceName)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("tbl_Place");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlaceName).HasColumnName("PlaceName");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
