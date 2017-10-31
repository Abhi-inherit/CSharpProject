using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Models.Mapping
{
    public class StudentDetailMap : EntityTypeConfiguration<StudentDetail>
    {
        public StudentDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.studentId);

            // Properties
            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.eMail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.password)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.course)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.district)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.gender)
                .IsRequired()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("StudentDetail");
            this.Property(t => t.studentId).HasColumnName("studentId");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.eMail).HasColumnName("eMail");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.course).HasColumnName("course");
            this.Property(t => t.district).HasColumnName("district");
            this.Property(t => t.gender).HasColumnName("gender");
        }
    }
}
