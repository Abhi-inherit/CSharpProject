using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MVC_PartialView.Models.Mapping
{
    public class tbl_PeopleMap : EntityTypeConfiguration<tbl_People>
    {
        public tbl_PeopleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.DateOfBirth)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(500);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            this.Property(t => t.Image)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("tbl_People");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.Place).HasColumnName("Place");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.tbl_Place)
                .WithMany(t => t.tbl_People)
                .HasForeignKey(d => d.Place);

        }
    }
}
