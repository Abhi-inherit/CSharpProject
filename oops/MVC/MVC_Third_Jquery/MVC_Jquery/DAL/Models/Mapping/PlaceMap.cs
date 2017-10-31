using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Models.Mapping
{
    public class PlaceMap : EntityTypeConfiguration<Place>
    {
        public PlaceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Places)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Places");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Places).HasColumnName("Places");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
