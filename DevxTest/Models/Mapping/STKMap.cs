using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DevxTest.Models.Mapping
{
    public class STKMap : EntityTypeConfiguration<STK>
    {
        public STKMap()
        {
            // Primary Key
            this.HasKey(t => t.MalKodu);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MalKodu)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.MalAdi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("STK");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MalKodu).HasColumnName("MalKodu");
            this.Property(t => t.MalAdi).HasColumnName("MalAdi");
        }
    }
}
